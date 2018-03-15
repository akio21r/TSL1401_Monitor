using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace InvertedPendulumControl
{
	public partial class frmMain : Form
	{
		bool	ThreadContinue = false;
		bool	recvOK;					//
		int		CommandWait1 = 60;		//コマンド送信してから受信待ちまでの時間[ms]=60
	//	int		CommandWait2 = 0;		//送信コマンド間の待ち時間[ms]
		int		CommandTimeOut = 5;		//送信エラー時の繰り返し回数の限度[回]
		public long	time1ms = 0;		//1ms毎にカウントアップする
		//各種モード
		public struct tMode{
			public bool	trace;
			public bool	power;
		}
		static public tMode mode = new tMode();

		//==========================================================================
		//ログデータ関連
		//==========================================================================
		public const int max_log_data_counts = 100000;		//10万行分のデータ★
		public struct LogData{
			public int		mode;			//mode
			public int		v, vt, vmax;	//速度、目標速度
			public int		angle, angle_t;	//ハンドル角、目標角度
			public int		power;			//モータ出力
			public int		pow, sv_pow;	//モータの出力
			public int		fl,fr,rl,rr;	//各輪のモータ出力
			public int		slope_mode;		//slope_mode;
			public int		slope_sw;		//坂SWの状態
			public int		slope_cnt;		//出発してからの坂の数
			public int		trip;			//トリップメータ
            public float	batt;           //バッテリ電圧
			public int		gyro;	    	//ジャイロ出力値
			public int		side;			//サイドセンサの状態
			public int		pos_sens;		//ポジションセンサ
			public int		time;			//時間[ms]
			public StringBuilder	sens;	//センサの状態（サイドセンサ含む）
			public int		pre_sens;		//先読みセンサ
		}
		static public LogData[] log = new LogData[max_log_data_counts];	//ログ
		static public LogData now = new LogData();
		
		//==========================================================================
		//グラフ関連
		//==========================================================================
		public bool graph_enabled = false;
		public const int graph_points = 4;
		public struct myGraphPoints{
			public bool enabled;
			public Single y, y1;
			public Pen pen;
			public Single scale, max, min;
		}
		static public myGraphPoints[] gp = new myGraphPoints[graph_points];

		static public int y0;							//X軸
		static public int cur_n1=0, cur_x=0, cur_x1=0;	//グラフ上の現在,前の位置
		static public bool cur_show = false;			//カーソル表示
		static public Single graph_v;					//グラフのX増分
		static public int scale_mode=1;					//縮尺のモード
		static public Point scrPoint1, scrPoint2;		//グラフのスクロール座標

		// PictureBoxと同サイズのBitmapオブジェクトを作成
		Bitmap bmp;
		Graphics g;

		int n, i;
		Single x, x1;


		//--------------------------------------------------------------
		StringBuilder log_str;
		int time;


		//--------------------------------------------------------------
		//コンストラクタ
		public frmMain(){
			InitializeComponent();

			if(serialPort1.IsOpen){
				serialPort1.Close();
			}

			log_str = new StringBuilder("未接続");


			ThreadContinue = true;
			backgroundWorker1.RunWorkerAsync();		//子スレッドを起動する
			backgroundWorker2.RunWorkerAsync();		//子スレッドを起動する
		}

		//--------------------------------------------------------------
		//メインフォームのクローズ処理（子スレッドも終了させる）
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e){
			ThreadContinue = false;			//無限ループを終わらせるフラグの設定
			if(serialPort1.IsOpen)
				serialPort1.Close();
			Thread.Sleep(10);				//子スレッドの終了を待つ

/*			//グラフ関連の破棄処理
			int i;
			for(i=0; i<graph_points; i++){
				gp[i].pen.Dispose();
			}
			g.Dispose();
*/		}


		//--------------------------------------------------------------
		//シリアルポートの接続
		private void btnConnect_Click(object sender, EventArgs e){
			if (serialPort1.IsOpen){
				serialPort1.Close();
			}
			try{
			//	lblPortConnect.Text = "・・・接続中";
				serialPort1.PortName = cmbPort.Text;
				serialPort1.BaudRate = int.Parse(cmbBaudRate.Text);
				serialPort1.Open();
			}
			catch{
				//cmbPort.SelectedIndex = 0;
			}
			if(serialPort1.IsOpen){
				lblPortConnect.Text = "・・・接続しました";
			}
			else{
				lblPortConnect.Text = "・・・切断";
			}

			//グラフの初期化
			initGraph();
		}

		//--------------------------------------------------------------
		//シリアルポートの切断
		private void btnDisConnect_Click(object sender, EventArgs e){
			if(serialPort1.IsOpen){
				serialPort1.Close();
			}
			lblPortConnect.Text = "・・・切断";
		}

		//--------------------------------------------------------------
		//子スレッドで実行されるプロシージャ
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){

			int recv_mode = -1;			// 受信モード  -1 : レスポンス受信モード,
										//            0～ : ログ受信モード
										//				 何バイト目のデータかを表す）
			int recv_byte;				// 受信データ
			byte[] buf = new byte[80];	// 受信バッファ
			bool logOK = false;			// ログデータが正常ならtrue

			
			
			while(ThreadContinue){
				if(serialPort1.IsOpen){
	
					////////////////////////////////////////////////////////////////
					//バイナリデータ受信用コード

					try{
						recv_byte = serialPort1.ReadByte();	//1バイト受信

						if(recv_mode == -1){				// レスポンス受信モード
							switch(recv_byte){
								case 0x01:					// OK レスポンス
									recvOK = true;
									break;
								case 0x02:					// Error レスポンス
									recvOK = false;
									break;
								case 0xff:					// ログパケットの開始コード
									recv_mode = 0;
									break;
							}
						}
						else{								// ログ受信モード
							buf[recv_mode++] = (byte)recv_byte;
							if(recv_mode == buf[0]+2){		// 終了コードの判定！！★
								if(recv_byte == 0xfe){		// 正常終了
									logOK = true;
									recv_mode = -1;
								}
								else{						// ログパケットの
									logOK = false;			// 終了コードが合っていない
									recv_mode = -1;
								}
							}
						}

					}
					catch {
					}

		
					if(logOK){
						logOK = false;
						
						now.mode	=   (sbyte)buf[1];	// モード
						byte sens	=          buf[2];	// デジタルセンサ状態

						now.angle_t	=   (sbyte)buf[3];	// 目標ハンドル角	[°]
						now.angle	=   (sbyte)buf[4];	// 現在のハンドル角	[°]

						now.sv_pow	=	(sbyte)buf[5];	// サーボモータの出力[%]
				
						now.vt		=   (sbyte)buf[6];	// 目標速度			[x10 m/s]
						now.v		=   (sbyte)buf[7];	// 現在の速度		[x10 m/s]
						now.fl		=   (sbyte)buf[8];	// 前左モータ出力	[%]
						now.fr		=	(sbyte)buf[9];	// 前右モータ出力	[%]
						now.rl		=	(sbyte)buf[10];	// 後左モータ出力	[%]
						now.rr		=	(sbyte)buf[11];	// 後右モータ出力	[%]
				
						sbyte slope		= (sbyte)buf[12]; // 坂状態[sl_mode, sw, sl_cnt]
						now.slope_mode	= (slope >> 6) & 0x03;
						now.slope_sw	= (slope >> 4) & 0x03;
						now.slope_cnt	= slope & 0x0f;
        
						now.trip	=   buf[13];	// スタートからの走行距離	[cm]
						now.trip	<<= 8;
						now.trip	+=  buf[14];

						now.batt	=   buf[15];		// バッテリー電圧
						now.gyro	=   (sbyte)buf[16];	// ジャイロセンサ出力

						now.side	=	(sbyte)buf[17];	// サイドセンサ状態
						now.side	>>= 6;
						now.side	&=  0x03;

						now.pre_sens =  (sbyte)buf[17];	// 先読みセンサ
						now.pre_sens >>= 5;
						now.pre_sens &= 0x01;

						sbyte pos_sens =  (sbyte)buf[17];	// ポジションセンサ状態
						pos_sens &= 0x1f;
						now.pos_sens = pos_sens;

						//-----------------------------
					
						//先読みセンサ
						if(now.pre_sens == 1)	now.sens = new StringBuilder(" P ");
						else					now.sens = new StringBuilder("   ");

						//ラインセンサ
						if((now.side & 0x02) != 0) now.sens.Append("S");		//★
						else                       now.sens.Append(" ");

						for(i=0; i<8; i++){
							switch(i){
								case 0: case 1: case 3: case 6: case 7:
									if((sens & 0x80) == 0)
										now.sens.Append("-");
									else
										now.sens.Append("*");
									break;
								case 4:
									break;
								case 2: case 5:
									if((sens & 0x80) == 0)
										now.sens.Append("-");
									else
										now.sens.Append("+");
									break;
							}		
							
							sens <<= 1;
						}
						if((now.side & 0x01) != 0) now.sens.Append("S");		//★
						else                       now.sens.Append(" ");



						now.sens.Append(" ");
						pos_sens <<= 3;
						for(i=0; i<5; i++){
							if((pos_sens & 0x80) == 0)
								now.sens.Append("-");
							else
								now.sens.Append("*");
							pos_sens <<= 1;
						}

						log_str.Clear();
						log_str.Append(String.Format("{0, 6}", time));
						time += 5;
						log_str.Append(String.Format("{0, 4}", now.mode));
						log_str.Append(now.sens);
						log_str.Append(" ");
						log_str.Append(String.Format("{0, 3}", now.angle_t));
						log_str.Append(" ");
						log_str.Append(String.Format("{0, 3}", now.angle));
						log_str.Append(" ");
						log_str.Append(String.Format("{0, 4}", now.sv_pow));
						log_str.Append(" ");
						log_str.Append(String.Format("{0, 4}", now.vt));
						log_str.Append(String.Format("{0, 4}", now.v));
						log_str.Append(" ");
						log_str.Append(String.Format("{0, 4}", now.fl));
						log_str.Append(String.Format("{0, 4}", now.fr));
						log_str.Append(String.Format("{0, 4}", now.rl));
						log_str.Append(String.Format("{0, 4}", now.rr));
						log_str.Append(String.Format("{0, 7}", now.trip));
						log_str.Append("  ");
						log_str.Append(String.Format("{0, 1}", now.slope_mode));
						log_str.Append(String.Format("{0, 1}", now.slope_sw));
						log_str.Append(String.Format("{0, 1}", now.slope_cnt));
						log_str.Append(String.Format("{0, 6:f1}", now.batt));
						log_str.Append(String.Format("{0, 6}", now.gyro));


					}
				
				}
				else{
					Thread.Sleep(5);
				}
			}
		}

		//--------------------------------------------------------------
		//子スレッドで実行されるプロシージャ
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e){
			while(ThreadContinue){
				time1ms += 10;
				Thread.Sleep(10);
			}
		}

		//--------------------------------------------------------------
		//コマンド送信
		private void SendCommand(string cmd){
			if( !serialPort1.IsOpen )
				return;

			recvOK = false;
			for(int n = 0; n < CommandTimeOut; n++){
				serialPort1.WriteLine(cmd);
				txtTerm.AppendText(cmd + "\n");

				time1ms = 0;
				while( time1ms < CommandWait1 ){
					if(recvOK)
						return;
				}
			}
		}

		//--------------------------------------------------------------
		//ログデータの読み込み処理（一定期間ごとに呼ばれる）
		private void timerLogView_Tick(object sender, EventArgs e){
			if(!serialPort1.IsOpen)
				return;

			DrawGraph();		
			

	//		string s = log_str.ToString();
	//	//	lstBox.Items.Add(s);
	//		txtRecv.Text = s;
		}

		//--------------------------------------------------------------
		//グラフの初期化
		void initGraph(){
			bmp = new Bitmap(pctGraph.Size.Width, pctGraph.Size.Height);
			pctGraph.Image = bmp;
			g = Graphics.FromImage(pctGraph.Image);

	
			y0 = pctGraph.Height / 2;	//水平線


			x1 = x = 0;
			graph_v = 1;				//xの増分

			for(i=y0; i<pctGraph.Height; i+=40){
				g.DrawLine(Pens.DarkSlateGray, 0, i, pctGraph.Width, i);
			}
			for(i=y0; i>0; i-=40){
				g.DrawLine(Pens.DarkSlateGray, 0, i, pctGraph.Width, i);
			}

			g.DrawLine(Pens.Gray,  0, y0, pctGraph.Width, y0);


			for(n=0; n<graph_points; n++){
				gp[n].y = gp[n].y1 = 0;
			}

			gp[ 0].pen = new Pen(Color.Yellow, 1);
			gp[ 1].pen = new Pen(Color.Cyan, 2);
			gp[ 2].pen = new Pen(Color.Cyan, 1);
			gp[ 3].pen = new Pen(Color.LightBlue, 1);

			gp[ 0].enabled = true;
			gp[ 1].enabled = true;
			gp[ 2].enabled = true;
			gp[ 3].enabled = true;

			gp[ 0].scale = 1;
			gp[ 1].scale = 5;
			gp[ 2].scale = 5;
			gp[ 3].scale = 1;

			graph_enabled = true;
		}

		//==========================================================================
		// Graphの描画
		//==========================================================================
		public void DrawGraph(){
			if( !graph_enabled ) return;

			int i;
			gp[ 0].y = -now.angle;
			gp[ 1].y = -now.v;
			gp[ 2].y = -now.vmax;
			gp[ 3].y = -now.gyro;
			for(i=0; i<graph_points; i++){
				gp[i].y = gp[i].y * gp[i].scale;
			}
	
			x += graph_v;
			if(x >= pctGraph.Width) x = graph_v;
			g.DrawLine(Pens.Navy, x, 0, x, pctGraph.Height-1);	//カーソルラインの消去

			for(i=y0; i<pctGraph.Height; i+=40){
				g.DrawLine(Pens.DarkSlateGray, x, i, x-1, i);
			}
			for(i=y0; i>0; i-=40){
				g.DrawLine(Pens.DarkSlateGray, x, i, x-1, i);
			}
			
			g.DrawLine(Pens.Gray, x, y0, x-1, y0);				//x軸
			

			for(i=graph_points-1; i>=0; i--){
				if(gp[i].enabled == true){
					if(x > x1){
						g.DrawLine(gp[i].pen, x, gp[i].y + y0, x1, gp[i].y1 + y0);
						gp[i].y1 = gp[i].y;
					}
					else{
						g.DrawLine(gp[i].pen, x, gp[i].y + y0, x-1, gp[i].y1 + y0);
						gp[i].y1 = gp[i].y;
					}
				}
			}
			g.DrawLine(Pens.LimeGreen, x+1, 0, x+1, pctGraph.Height-1);	//カーソル描画
			x1 = x;
			pctGraph.Refresh();
		}


		//--------------------------------------------------------------
		//テストボタンクリック
		private void btnTestA_Click(object sender, EventArgs e){
		//	SendCommand(btnTestA.Text);
		}

		void set_difference(  ){
			if(nudSetAngle.Value == 0){
				nudSetFL.Value = nudSetPower.Value;
				nudSetFR.Value = nudSetPower.Value;
				nudSetRL.Value = nudSetPower.Value;
				nudSetRR.Value = nudSetPower.Value;
			}
			else{
				double wb, tf, tr;
				double angle, pow;
				double fo, fi, ro, ri;
				double pow_fo, pow_fi, pow_ro, pow_ri;
			
				wb = double.Parse(txtWB.Text);	//ホイールベース
				tf = double.Parse(txtTF.Text);	//フロントトレッド
				tr = double.Parse(txtTR.Text);	//リアトレッド

				angle = (double)Math.Abs(nudSetAngle.Value);
				pow   = (double)nudSetPower.Value;

				fo = wb / Math.Sin(angle * Math.PI / 180) + tf / 2;
				fi = wb / Math.Sin(angle * Math.PI / 180) - tf / 2;
				ro = wb / Math.Tan(angle * Math.PI / 180) + tr / 2;
				ri = wb / Math.Tan(angle * Math.PI / 180) - tr / 2;

				pow_fo = Math.Round(pow, 0);
				pow_fi = Math.Round(pow * fi / fo, 0);
				pow_ro = Math.Round(pow * ro / fo, 0);
				pow_ri = Math.Round(pow * ri / fo, 0);

				if(nudSetAngle.Value > 0){
					nudSetFL.Value = (decimal)pow_fo;
					nudSetFR.Value = (decimal)pow_fi;
					nudSetRL.Value = (decimal)pow_ro;
					nudSetRR.Value = (decimal)pow_ri;
				}
				else{
					nudSetFL.Value = (decimal)pow_fi;
					nudSetFR.Value = (decimal)pow_fo;
					nudSetRL.Value = (decimal)pow_ri;
					nudSetRR.Value = (decimal)pow_ro;
				}
			}
	
		}
			
		private void btnTestB_Click(object sender, EventArgs e){
			SendCommand("t1;");
		}

		private void txtTerm_TextChanged(object sender, EventArgs e){

		}

		private void txtTerm_KeyPress(object sender, KeyPressEventArgs e){
			if(serialPort1.IsOpen){
				byte[] b = new byte[1];
				b[0] = (byte)e.KeyChar;
				serialPort1.Write(b, 0, 1);
			}
		}

		private void nudSetAngle_ValueChanged(object sender, EventArgs e){
			chkSetTrace.Checked = false;
			SendCommand("h" + nudSetAngle.Value + ";");
			trackBarHandle.Value = (int)nudSetAngle.Value;
		
		
			if( !chkModePowerAll.Checked ){
				set_difference();
			}
		}

		private void nudSetPower_ValueChanged(object sender, EventArgs e){
			mode.power = true;
			
			trackBarPower.Value = (int)nudSetPower.Value;
			if( !chkModePowerAll.Checked ){
				set_difference();
			}
			if( !chkModePowerAll.Checked ){
				SendCommand("p" + nudSetPower.Value + ";");
			}
		}

		private void nudSetAllMotor_ValueChanged(object sender, EventArgs e){
			if(chkModePowerAll.Checked){
				SendCommand("m" + nudSetFL.Value + "," + nudSetFR.Value + ","
								+ nudSetRL.Value + "," + nudSetRR.Value + ";");
			}
		}
		
		private void chkSetFreeAll_CheckedChanged(object sender, EventArgs e){
			int a, b, c, d;
			a = (chkSetFreeFL.Checked)? 1:0;
			b = (chkSetFreeFR.Checked)? 1:0;
			c = (chkSetFreeRL.Checked)? 1:0;
			d = (chkSetFreeRR.Checked)? 1:0;

			SendCommand("f" + a + "," + b + "," + c + "," + d); 
		}

		private void chkSetTrace_Click(object sender, EventArgs e){
			if(chkSetTrace.Checked){
				SendCommand("t1;");
			}
			else{
				nudSetAngle.Value = decimal.Parse(txtViewAngle.Text);
				SendCommand("t0;h" + nudSetAngle.Value + ";");
			}
		}

		private void vscrlPower_Scroll(object sender, ScrollEventArgs e){

		}

		private void trackBarHandle_Scroll(object sender, EventArgs e){
			nudSetAngle.Value = trackBarHandle.Value;
		}

		private void trackBarPower_Scroll(object sender, EventArgs e){
			nudSetPower.Value = trackBarPower.Value;
		}

		private void chkModePower_CheckedChanged(object sender, EventArgs e){

		}

		private void chkModePowerAll_CheckedChanged(object sender, EventArgs e){
			if(chkModePowerAll.Checked){

			//	if(mode.power){
			//		nudSetFL.Text = txtViewFL.Text;
			//		nudSetFR.Text = txtViewFR.Text;
			//		nudSetRL.Text = txtViewRL.Text;
			//		nudSetRR.Text = txtViewRR.Text;
			//	}			
				nudSetAngle.Enabled = false;
				trackBarHandle.Enabled = false;
				
				nudSetPower.Enabled = false;
				trackBarPower.Enabled = false;
				nudSetFL.Enabled = true;
				nudSetFR.Enabled = true;
				nudSetRL.Enabled = true;
				nudSetRR.Enabled = true;
			}
			else{
				nudSetAngle.Enabled = true;
				trackBarHandle.Enabled = true;

				nudSetPower.Enabled = true;
				trackBarPower.Enabled = true;
				nudSetFL.Enabled = false;
				nudSetFR.Enabled = false;
				nudSetRL.Enabled = false;
				nudSetRR.Enabled = false;
			}
		}

		private void btnMotorAllCopy_Click(object sender, EventArgs e){
			nudSetFL.Value = decimal.Parse(txtViewFL.Text);
			nudSetFR.Value = decimal.Parse(txtViewFR.Text);
			nudSetRL.Value = decimal.Parse(txtViewRL.Text);
			nudSetRR.Value = decimal.Parse(txtViewRR.Text);
		}

		private void btnStart_Click(object sender, EventArgs e){
			SendCommand("s1;");
		}

		private void btnStop_Click(object sender, EventArgs e){
			SendCommand("s0;");
		}

		private void btnAllMotorStop_Click(object sender, EventArgs e){
			SendCommand("p0;");
			nudSetPower.Value = 0;
			nudSetFL.Value = 0;
			nudSetFR.Value = 0;
			nudSetRL.Value = 0;
			nudSetRR.Value = 0;
		}

/*		private void frmMain_KeyPress(object sender, KeyPressEventArgs e){
			Char key = Char.ToLower(e.KeyChar);
			switch(e.KeyChar){
				case '\r': checkBox1.Checked = !checkBox1.Checked; break;
					//	SendCommand("p0;"); break;	//緊急停止
				case 'a': if(nudSetRL.Value < 100) nudSetRL.Value++; break;
				case 'z': if(nudSetRL.Value >   0) nudSetRL.Value--; break;
				case 's': if(nudSetFL.Value < 100) nudSetFL.Value++; break;
				case 'x': if(nudSetFL.Value >   0) nudSetFL.Value--; break;
				case 'd': if(nudSetFR.Value < 100) nudSetFR.Value++; break;
				case 'c': if(nudSetFR.Value >   0) nudSetFR.Value--; break;
				case 'f': if(nudSetRR.Value < 100) nudSetRR.Value++; break;
				case 'v': if(nudSetRR.Value >   0) nudSetRR.Value--; break;
			}
			btnAllMotorStop.Focus();
		}
*/
		private void frmMain_KeyDown(object sender, KeyEventArgs e){
			btnAllMotorStop.Focus();
			switch(e.KeyCode){
				case Keys.Return: checkBox1.Checked = !checkBox1.Checked; break;
								//	SendCommand("p0;"); break;		//緊急停止
				case Keys.Space: checkBox1.Checked = !checkBox1.Checked; break;
								//	SendCommand("p0;"); break;		//緊急停止
				case Keys.A: if(nudSetRL.Value < 100) nudSetRL.Value++; break;
				case Keys.Z: if(nudSetRL.Value >   0) nudSetRL.Value--; break;
				case Keys.S: if(nudSetFL.Value < 100) nudSetFL.Value++; break;
				case Keys.X: if(nudSetFL.Value >   0) nudSetFL.Value--; break;
				case Keys.D: if(nudSetFR.Value < 100) nudSetFR.Value++; break;
				case Keys.C: if(nudSetFR.Value >   0) nudSetFR.Value--; break;
				case Keys.F: if(nudSetRR.Value < 100) nudSetRR.Value++; break;
				case Keys.V: if(nudSetRR.Value >   0) nudSetRR.Value--; break;
			}
		}
	}
}
