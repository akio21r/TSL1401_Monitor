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
			public int		gyro, gyro_raw;	//ジャイロセンサ出力値
			public int		accel;			//加速度センサ出力値
			public int		angle;			//角度（ジャイロの積分値）
			public int		EncL, EncR;		//モータエンコーダ値
			public int		SpeedL, SpeedR;	//モータスピード値


			public int		mode;			//mode
			public int		v, vt, vmax;	//速度、目標速度
			public int		power;			//モータ出力
			public int		pow, sv_pow;	//モータの出力
			public int		fl,fr,rl,rr;	//各輪のモータ出力
			public int		slope_mode;		//slope_mode;
			public int		slope_sw;		//坂SWの状態
			public int		slope_cnt;		//出発してからの坂の数
			public int		trip;			//トリップメータ
            public float	batt;           //バッテリ電圧
			public int		side;			//サイドセンサの状態
			public int		pos_sens;		//ポジションセンサ
			public int		time;			//時間[ms]
			public StringBuilder	sens;	//センサの状態（サイドセンサ含む）
			public int		pre_sens;		//先読みセンサ
		}
		static public LogData[] log = new LogData[max_log_data_counts];	//ログ
		static public LogData now = new LogData();
		static public int[] recv_data = new int[32];	//受信データの一時格納場所
		static public int   recv_data_n;				//受信データの数
		
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

		
					if(logOK){				//buf[1]から読み取っていく（buf[0]はバイト数）
						int i;
						logOK = false;

						recv_data_n = (sbyte)buf[0] / 2;

						for(i = 0; i < recv_data_n; i++){
							recv_data[i] = (sbyte)buf[ i*2 + 1 ];
							recv_data[i] <<= 8;
							recv_data[i] |= buf[ i*2 + 2 ];
						}

						/*
						now.gyro	=   (sbyte)buf[1];	//ジャイロセンサ　上位8ビット
						now.gyro	<<= 8;
						now.gyro	|=  buf[2];			//ジャイロセンサ　下位8ビット

						now.accel   =   (sbyte)buf[3];	//加速度センサ　上位8ビット
						now.accel	<<= 8;
						now.accel	|=  buf[4];			//加速度センサ　下位8ビット

						now.angle   =   (sbyte)buf[5];	//角度　上位8ビット
						now.angle	<<= 8;
						now.angle	|=  buf[6];			//角度　下位8ビット


						now.SpeedL   =   (sbyte)buf[7];	//角度　上位8ビット
						now.SpeedL	<<= 8;
						now.SpeedL	|=  buf[8];			//角度　下位8ビット

						now.SpeedR   =   (sbyte)buf[9];	//角度　上位8ビット
						now.SpeedR	<<= 8;
						now.SpeedR	|=  buf[10];		//角度　下位8ビット

						now.gyro_raw	=   (sbyte)buf[11];	//ジャイロRaw
						now.gyro_raw	<<= 8;
						now.gyro_raw	|=  buf[12];
						*/						
						
						
						log_str.Clear();
						log_str.Append(String.Format("{0, 6}", time));
						time += 5;
						log_str.Append(String.Format("{0, 4}", now.mode));
						log_str.Append(now.sens);
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
			txtGyro.Text = now.gyro.ToString();
			txtAccel.Text = now.accel.ToString();
			txtAngle.Text = now.angle.ToString();
			txtSpeedL.Text = now.SpeedL.ToString();
			txtSpeedR.Text = now.SpeedR.ToString();
			txtEncL.Text = now.EncL.ToString();
			txtEncR.Text = now.EncR.ToString();

			lstBox.Items.Clear();
			for(int i=0; i<recv_data_n; i++){
				lstBox.Items.Add(i + ": " + recv_data[i].ToString());
			}
/*			lstBox.Items.Add("1: " + now.gyro.ToString());
			lstBox.Items.Add("2: " + now.accel.ToString());
			lstBox.Items.Add("3: " + now.angle.ToString());
			lstBox.Items.Add("4: " + now.SpeedL.ToString());
			lstBox.Items.Add("5: " + now.SpeedR.ToString());
			lstBox.Items.Add("6: " + now.gyro_raw.ToString());
			lstBox.Items.Add("7: " + now.EncL.ToString());
			lstBox.Items.Add("8: " + now.EncR.ToString());
			*/

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
			graph_v = 2;				//xの増分

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

			gp[ 0].scale = 1F;
			gp[ 1].scale = 1F;
			gp[ 2].scale = 0.1F;
			gp[ 3].scale = 1F;

			graph_enabled = true;
		}

		//==========================================================================
		// Graphの描画
		//==========================================================================
		public void DrawGraph(){
			if( !graph_enabled ) return;

			int i;
			for(i=0; i<4; i++){
				gp[i].y = -recv_data[i];
			}
			gp[3].y = -recv_data[4];


			for(i=0; i<graph_points; i++){
				gp[i].y = gp[i].y * gp[i].scale;
			}
	
			x += graph_v;
			if(x >= pctGraph.Width) x = graph_v;
		//	g.DrawLine(Pens.Navy, x, 0, x, pctGraph.Height-1);	//カーソルラインの消去
			g.FillRectangle(Brushes.Navy, x, 0, graph_v, pctGraph.Height-1);
			
			for(i=y0; i<pctGraph.Height; i+=40){
				g.DrawLine(Pens.DarkSlateGray, x, i, x-graph_v, i);		//横目盛り線
			}
			for(i=y0; i>0; i-=40){
				g.DrawLine(Pens.DarkSlateGray, x, i, x-graph_v, i);		//横目盛り線
			}
			
			g.DrawLine(Pens.Gray, x, y0, x-graph_v, y0);				//x軸
			

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
			g.DrawLine(Pens.LimeGreen, x+graph_v, 0, x+graph_v, pctGraph.Height-1);	//カーソル描画
			x1 = x;

	
			
	//		ScrollWindowEx(this.Handle, 0, -16, 
			
			
			
			pctGraph.Refresh();
		}


		//--------------------------------------------------------------
		//テストボタンクリック
		private void btnTestA_Click(object sender, EventArgs e){
		//	SendCommand(btnTestA.Text);
		}

		void set_difference(  ){
			if(nudSetAngle.Value == 0){
				nudSetML.Value = nudSetPower.Value;
				nudSetMR.Value = nudSetPower.Value;
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
					nudSetML.Value = (decimal)pow_fo;
					nudSetMR.Value = (decimal)pow_fi;
					nudSetRL.Value = (decimal)pow_ro;
					nudSetRR.Value = (decimal)pow_ri;
				}
				else{
					nudSetML.Value = (decimal)pow_fi;
					nudSetMR.Value = (decimal)pow_fo;
					nudSetRL.Value = (decimal)pow_ri;
					nudSetRR.Value = (decimal)pow_ro;
				}
			}
	
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
			nudSetML.Value = nudSetPower.Value;
			nudSetMR.Value = nudSetPower.Value;
			SendCommand("l" + nudSetML.Value + ";");
			SendCommand("r" + nudSetMR.Value + ";");
			
			trackBarPower.Value = (int)nudSetPower.Value;
		}

		private void nudSetAllMotor_ValueChanged(object sender, EventArgs e){
			if(chkModePowerAll.Checked){
				SendCommand("l" + nudSetML.Value + ";");
				SendCommand("r" + nudSetMR.Value + ";");
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
				nudSetAngle.Value = decimal.Parse(txtAngle.Text);
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
				nudSetML.Enabled = true;
				nudSetMR.Enabled = true;
				nudSetRL.Enabled = true;
				nudSetRR.Enabled = true;
			}
			else{
				nudSetAngle.Enabled = true;
				trackBarHandle.Enabled = true;

				nudSetPower.Enabled = true;
				trackBarPower.Enabled = true;
				nudSetML.Enabled = false;
				nudSetMR.Enabled = false;
				nudSetRL.Enabled = false;
				nudSetRR.Enabled = false;
			}
		}

		private void btnStart_Click(object sender, EventArgs e){
			SendCommand("s1;");
			SendCommand("1;");
		}

		private void btnStop_Click(object sender, EventArgs e){
			SendCommand("s0;");
			SendCommand("0;");
		}

		private void btnAllMotorStop_Click(object sender, EventArgs e){
			nudSetPower.Value = 0;
			nudSetML.Value = 0;
			nudSetMR.Value = 0;
			SendCommand("l" + nudSetML.Value + ";");
			SendCommand("r" + nudSetMR.Value + ";");
			SendCommand("s0;");
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e){
		/*	btnAllMotorStop.Focus();
			switch(e.KeyCode){
				case Keys.Return: checkBox1.Checked = !checkBox1.Checked; break;
								//	SendCommand("p0;"); break;		//緊急停止
				case Keys.Space: checkBox1.Checked = !checkBox1.Checked; break;
								//	SendCommand("p0;"); break;		//緊急停止
				case Keys.A: if(nudSetRL.Value < 100) nudSetRL.Value++; break;
				case Keys.Z: if(nudSetRL.Value >   0) nudSetRL.Value--; break;
				case Keys.S: if(nudSetML.Value < 100) nudSetML.Value++; break;
				case Keys.X: if(nudSetML.Value >   0) nudSetML.Value--; break;
				case Keys.D: if(nudSetMR.Value < 100) nudSetMR.Value++; break;
				case Keys.C: if(nudSetMR.Value >   0) nudSetMR.Value--; break;
				case Keys.F: if(nudSetRR.Value < 100) nudSetRR.Value++; break;
				case Keys.V: if(nudSetRR.Value >   0) nudSetRR.Value--; break;
			}
		*/
		}

		private void btnSendCommand_Click(object sender, EventArgs e)
		{
			SendCommand("cf1=" + txtF1.Text);
			SendCommand("cf2=" + txtF2.Text);
			SendCommand("cf3=" + txtF3.Text);
			SendCommand("cf4=" + txtF4.Text);
			SendCommand("cf5=" + txtF5.Text);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			SendCommand("z");
		}

	}
}
