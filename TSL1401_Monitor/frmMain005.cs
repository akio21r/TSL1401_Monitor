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
		int recv_mode = -1;		// 受信モード  -1 : レスポンス受信モード,
								//            0～ : ログ受信モード
								//				    何バイト目のデータかを表す）

	
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
			public int		angle;			//車体傾斜角度
			public int		angle_v;		//車体傾斜角速度
			public int		x;				//車体の原点からの移動距離
			public int		v;				//車体の移動速度
			public int		EncL, EncR;		//モータエンコーダ値
			public int		SpeedL, SpeedR;	//モータスピード値
		}
		static public LogData[] log = new LogData[max_log_data_counts];	//ログ
		static public LogData now = new LogData();
		static public int[] recv_data = new int[32];	//受信データの一時格納場所
		static public int   recv_data_n;				//受信データの数
		
		//==========================================================================
		//グラフ関連
		//==========================================================================
		public bool graph_enabled = false;
		public const int graph_points = 7;
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
		Bitmap bmp;						//描画イメージを保持しておくためのBitmap
//		Graphics g;

		int n;
		Single x, x1;

		//--------------------------------------------------------------
		//コンストラクタ
		public frmMain(){
			InitializeComponent();

			if(serialPort1.IsOpen){
				serialPort1.Close();
			}

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
			const int BUFFER_SIZE = 80;
			int recv_byte;						// 受信データ
			byte[] buf = new byte[BUFFER_SIZE];	// 受信バッファ
			bool logOK = false;					// ログデータが正常ならtrue

			
			
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
								recv_mode = -1;
								if(recv_byte == 0xfe){		// 正常終了
									logOK = true;
								}
								else{						// ログパケットの
			//						logOK = true;			// 終了コードが合っていない
									logOK = false;			// 終了コードが合っていない
								}
							}
							if(recv_mode >= BUFFER_SIZE){	//受信データ数が受信バッファを超えたらリセット
								recv_mode = -1;
								recv_byte = 0;
								recvOK = false;
								logOK = false;
								serialPort1.DiscardInBuffer();
							}
						}

					}
					catch {
					}

					//シリアルポートから読み取ったバイナリデータを
					//recv_data[]に格納しておく
					if(logOK){			//buf[1]から読み取っていく（buf[0]はバイト数）
						int i;
						logOK = false;

						recv_data_n = (sbyte)buf[0] / 2;

						for(i = 0; i < recv_data_n; i++){
							recv_data[i] = (sbyte)buf[ i*2 + 1 ];
							recv_data[i] <<= 8;
							recv_data[i] |= buf[ i*2 + 2 ];
						}

						now.gyro	= recv_data[0];
						now.accel	= recv_data[1];
						now.angle	= recv_data[2];
						now.angle_v	= recv_data[3];
						now.x		= recv_data[4];
						now.v		= recv_data[5];
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

//			while( recv_mode != -1 );	//ログ受信中の間は
										//レスポンスモードになるまで待つ

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
			if(!serialPort1.IsOpen)	return;

			DrawGraph();		
			txtGyro.Text = now.gyro.ToString();
			txtAccel.Text = now.accel.ToString();
			txtAngle.Text = now.angle.ToString();
			txtAngle_v.Text = now.angle_v.ToString();
			txtX.Text = now.x.ToString();
			txtV.Text = now.v.ToString();

			txtSpeedL.Text = now.SpeedL.ToString();
			txtSpeedR.Text = now.SpeedR.ToString();
			txtEncL.Text = now.EncL.ToString();
			txtEncR.Text = now.EncR.ToString();

			lstBox.Items.Clear();
			for(int i=0; i<recv_data_n; i++){
				lstBox.Items.Add(i + ": " + recv_data[i].ToString());
			}
		//	lstBox.Items.Add("logOK:" + logOK
		}

		//--------------------------------------------------------------
		//グラフの初期化
		void initGraph(){
			int i;
			bmp = new Bitmap(pctGraph.Size.Width, pctGraph.Size.Height);

			pctGraph.Image = bmp;
			Graphics g = Graphics.FromImage(pctGraph.Image);

			y0 = pctGraph.Height / 2;	//水平線
			x1 = x = 0;
			graph_v = 1;				//xの増分
		
			g.DrawLine(Pens.Gray,  0, y0, pctGraph.Width, y0);
			for(i = y0+40; i < pctGraph.Height; i += 40){
				g.DrawLine(Pens.DarkSlateGray, 0, i, pctGraph.Width, i);
			}
			for(i = y0-40; i > 0; i -= 40){
				g.DrawLine(Pens.DarkSlateGray, 0, i, pctGraph.Width, i);
			}



			for(n=0; n<graph_points; n++){
				gp[n].y = gp[n].y1 = y0;
			}

			gp[ 0].pen = new Pen(Color.Yellow, 1);
			gp[ 1].pen = new Pen(Color.Cyan, 1);
			gp[ 2].pen = new Pen(Color.Lime, 1);
			gp[ 3].pen = new Pen(Color.LightBlue, 1);
			gp[ 4].pen = new Pen(Color.Yellow, 2);
			gp[ 5].pen = new Pen(Color.Blue, 2);
			gp[ 6].pen = new Pen(Color.Green, 2);

			gp[ 0].enabled = true;
			gp[ 1].enabled = true;
			gp[ 2].enabled = true;
			gp[ 3].enabled = true;
			gp[ 4].enabled = true;
			gp[ 5].enabled = true;
			gp[ 6].enabled = true;

			gp[ 0].scale = 0.1F;
			gp[ 1].scale = 0.1F;
			gp[ 2].scale = 0.1F;
			gp[ 3].scale = 0.1F;
			gp[ 4].scale = 0.1F;
			gp[ 5].scale = 0.1F;
			gp[ 6].scale = 0.1F;

			graph_enabled = true;

			g.Dispose();
		}

		//==========================================================================
		// Graphの描画
		//==========================================================================
		public void DrawGraph(){
			Graphics gx = pctGraph.CreateGraphics();
			Graphics g = Graphics.FromImage(bmp);		//BitmapのGraphicsを作成
			int i;
	
			// クローンBitmapを作成し、1ドットずらす
			Image bmx = (Image)bmp.Clone();
			g.DrawImage(bmx, -graph_v, 0);


			//----------------------------------------------------------------------

			//右端を消す
			g.FillRectangle(Brushes.Navy, pctGraph.Width - graph_v, 0, pctGraph.Width, pctGraph.Height-1);

			//横軸描画
			g.DrawLine(Pens.Gray,  pctGraph.Width - graph_v, y0, pctGraph.Width, y0);
			for(i = y0+40; i < pctGraph.Height; i += 40){
				g.DrawLine(Pens.DarkSlateGray, pctGraph.Width - graph_v, i, pctGraph.Width, i);
			}
			for(i = y0-40; i > 0; i -= 40){
				g.DrawLine(Pens.DarkSlateGray, pctGraph.Width - graph_v, i, pctGraph.Width, i);
			}
			//----------------------------------------------------------------------

			if( !graph_enabled ) return;

			for(i=0; i<7; i++){
				gp[i].y = recv_data[i];
			}

			for(i=0; i<graph_points; i++){
				gp[i].y = gp[i].y * gp[i].scale;
			}
		
			x = pctGraph.Width - 1;
			for(i=0; i<7; i++){
				if(gp[i].enabled) g.DrawLine(gp[i].pen, x, gp[i].y + y0, x - graph_v, gp[i].y1 + y0);
				gp[i].y1 = gp[i].y;
			}

			//----------------------------------------------------------------------
			gx.DrawImage(bmp, 0, 0);	//Bitmapの描画結果をPictureBoxに反映
			gx.Dispose();				//Graphicsの解放
			g.Dispose();				//Graphicsの解放
		}

		//--------------------------------------------------------------
		//テストボタンクリック
		private void btnTestA_Click(object sender, EventArgs e){
			SendCommand("g;");
		}

		void set_difference(  ){
			if(nudSetAngle.Value == 0){
				nudSetML.Value = nudSetPower.Value;
				nudSetMR.Value = nudSetPower.Value;
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
				}
				else{
					nudSetML.Value = (decimal)pow_fi;
					nudSetMR.Value = (decimal)pow_fo;
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
			SendCommand("l" + nudSetPower.Value + ";");
			SendCommand("r" + nudSetPower.Value + ";");
			
			trackBarPower.Value = (int)nudSetPower.Value;
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
			if(chkModePower.Checked == true)
				SendCommand("t1;");				//モータテストモード
			else
				SendCommand("t0;");				//モータテストモード解除
		}

		private void chkModePowerAll_CheckedChanged(object sender, EventArgs e){
			if(chkModePowerAll.Checked){
				nudSetAngle.Enabled = false;
				trackBarHandle.Enabled = false;
				
				nudSetPower.Enabled = false;
				trackBarPower.Enabled = false;
				nudSetML.Enabled = true;
				nudSetMR.Enabled = true;
			}
			else{
				nudSetAngle.Enabled = true;
				trackBarHandle.Enabled = true;

				nudSetPower.Enabled = true;
				trackBarPower.Enabled = true;
				nudSetML.Enabled = false;
				nudSetMR.Enabled = false;
			}
		}

		private void btnStart_Click(object sender, EventArgs e){
			SendCommand("s1;");
		//	SendCommand("1;");
		}

		private void btnStop_Click(object sender, EventArgs e){
			SendCommand("s0;");
		//	SendCommand("0;");
		}

		private void btnAllMotorStop_Click(object sender, EventArgs e){
			nudSetPower.Value = 0;
			nudSetML.Value = 0;
			nudSetMR.Value = 0;
			SendCommand("l" + nudSetML.Value + ";");
			SendCommand("r" + nudSetMR.Value + ";");
			SendCommand("s0;");
		}

		private void btnSendCommand_Click(object sender, EventArgs e)
		{
			SendCommand("cf1=" + txtF1.Text + ";");
			SendCommand("cf2=" + txtF2.Text + ";");
			SendCommand("cf3=" + txtF3.Text + ";");
			SendCommand("cf4=" + txtF4.Text + ";");
			SendCommand("cf5=" + txtF5.Text + ";");
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			SendCommand("z;");
			serialPort1.DiscardInBuffer();
		}

		private void nudSetML_ValueChanged(object sender, EventArgs e)
		{
			if(chkModePowerAll.Checked){
				SendCommand("l" + nudSetML.Value + ";");
			}

		}

		private void nudSetMR_ValueChanged(object sender, EventArgs e)
		{
			if(chkModePowerAll.Checked){
				SendCommand("r" + nudSetMR.Value + ";");
			}

		}

		private void btnTest_01_Click(object sender, EventArgs e)
		{
			SendCommand("t2;");
		}

		private void btnSerialReset_Click(object sender, EventArgs e)
		{
			serialPort1.DiscardInBuffer();
		}

		private void chkG0_CheckedChanged(object sender, EventArgs e)
		{
			gp[0].enabled = chkG0.Checked;
		}

		private void chkG1_CheckedChanged(object sender, EventArgs e)
		{
			gp[1].enabled = chkG1.Checked;
		}

		private void chkG2_CheckedChanged(object sender, EventArgs e)
		{
			gp[2].enabled = chkG2.Checked;
		}

		private void chkG3_CheckedChanged(object sender, EventArgs e)
		{
			gp[3].enabled = chkG3.Checked;
		}

		private void chkG4_CheckedChanged(object sender, EventArgs e)
		{
			gp[4].enabled = chkG4.Checked;
		}

		private void chkG5_CheckedChanged(object sender, EventArgs e)
		{
			gp[5].enabled = chkG5.Checked;
		}

		private void chkG6_CheckedChanged(object sender, EventArgs e)
		{
			gp[6].enabled = chkG6.Checked;
		}

		private void chkRecvOK_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void chkLog_CheckedChanged(object sender, EventArgs e)
		{
			if(chkLog.Checked) SendCommand("d1;");
			else               SendCommand("d0;");
		}


	
	}
}
