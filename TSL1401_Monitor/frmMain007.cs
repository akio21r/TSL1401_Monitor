using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TSL1401_Monitor
{
	public partial class frmMain : Form
	{
		int recv_mode = -1;		// 受信モード  -1 : レスポンス受信モード,
								//            0～ : ログ受信モード
								//				    何バイト目のデータかを表す）

		int		LogRecord = 40;		//ログデータのバイト数
	
		bool	ThreadContinue = false;
		bool	recvOK;					//
	//	int		CommandWait1 = 100;		//コマンド送信してから受信待ちまでの時間[ms]=60
	//	int		CommandWait2 = 0;		//送信コマンド間の待ち時間[ms]
		int		CommandTimeOut = 5;		//送信エラー時の繰り返し回数の限度[回]
	//	public long	time1ms = 0;		//1ms毎にカウントアップする
		//各種モード
		public struct tMode{
			public bool	trace;
			public bool	power;
		}
		static public tMode mode = new tMode();

		//シリアルポート受信バッファ内のバイト数調査用
		int spRcvBufNum2, spRcvBufMax2 = 0;

		//==========================================================================
		//ログデータ関連
		//==========================================================================
		public const int max_log_data_counts = 100000;		//10万行分のデータ★
		public struct LogData{
			public int		cam_integration;
			public int		cam_delay_pulse;
			public int		cam_CenterIndex;
			public int		cam_Sens;
		}
		static public LogData now = new LogData();

		static public byte[] Camera = new byte[128];	//カメラの画素データ
		static public int[] Camera2 = new int[128];		//カメラの画素データ
		static public int Camera_min, Camera_max, Camera_center;	//センターライン検出用
		static public int Camera_min_index, Camera_max_index, Camera_center_index;
		static public int Camera_N;						//カメラの画素数
		static public int Camera_CenterIndex;			//センター値
		static public int Camera_Sens;					//デジタルセンサ値
		static public int Camera_Center;				//
		static public int Camera_MinIndex;				//
		static public int Camera_MaxIndex;				//
		

		static public int[] recv_data = new int[32];	//画素データ以外の受信データ一時格納場所
		static public int   recv_data_n;				//画素データ以外の受信データの数
		
		//==========================================================================
		//グラフ関連
		//==========================================================================
		public bool graph_enabled = false;
		public const int graph_points = 8;
		public struct myGraphPoints{
			public bool enabled;
			public Single y, y1;
			public Pen pen;
			public Single scale, max, min;
		}
		static public myGraphPoints[] gp = new myGraphPoints[graph_points];

		static public int x0, y0;						//軸
		static public int cur_n1=0, cur_x=0, cur_x1=0;	//グラフ上の現在,前の位置
		static public bool cur_show = false;			//カーソル表示
		static public Single graph_v;					//グラフのX増分
		static public int scale_mode=1;					//縮尺のモード
		static public Point scrPoint1, scrPoint2;		//グラフのスクロール座標

		// PictureBoxと同サイズのBitmapオブジェクトを作成
		Bitmap bmp, bmp2;								//描画イメージを保持しておくためのBitmap
		Graphics g2;

		SolidBrush[] brsh = new SolidBrush[16];			//ブラシ

		int n;

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

//			LogRecord = (int)nudLogRecord.Value;

			//ブラシ作成
			for(int i=0; i<16; i++){
				brsh[i] = new SolidBrush(Color.FromArgb(i*17, i*17, i*17));
			}
		}

		//--------------------------------------------------------------
		//メインフォームのクローズ処理（子スレッドも終了させる）
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e){
			ThreadContinue = false;			//無限ループを終わらせるフラグの設定
			if(serialPort1.IsOpen)
				serialPort1.Close();
			Thread.Sleep(10);				//子スレッドの終了を待つ

			//グラフ関連の破棄処理
			for(int i=0; i<16; i++){		//ブラシ破棄
				brsh[i].Dispose();
			}
/*
			for(int i=0; i<graph_points; i++){
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
				lblPortConnect.Text = "・・・接続中";
				SendCommand("+;");
			}
			else{
				lblPortConnect.Text = "・・・切断";
			}

			//グラフの初期化
			initGraph();

			lblLogRecordSize.Text = "Logのバイト数 = " + LogRecord.ToString();

			chkLog.Checked = true;
		}

		//--------------------------------------------------------------
		//シリアルポートの切断
		private void btnDisConnect_Click(object sender, EventArgs e){
			if(serialPort1.IsOpen){
				serialPort1.Close();
			}
			chkLog.Checked = false;
			lblPortConnect.Text = "・・・切断";
		}

		//--------------------------------------------------------------
		//子スレッドで実行されるプロシージャ
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){
			const int	BUFFER_SIZE = 256;
			byte[]		rxbuf = new byte[BUFFER_SIZE];	// 受信バッファ
			bool		logOK = false;					// ログデータが正常ならtrue
			int recv_byte;						// 受信データ

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
								case 0x03:					// 通信開始時の情報交換
									recvOK = true;

									//ログパケットのレコードサイズ取得
									LogRecord = serialPort1.ReadByte();
									break;

								case 0xff:					// ログパケットの開始コード
									recv_mode = 0;
									break;
							}
						}
						else{								//ログ受信モード
							rxbuf[recv_mode++] = (byte)recv_byte;

							//ログデータのバイト数をチェックし、違っていたら破棄する。
							if(rxbuf[0] != LogRecord){
								recv_mode = -1;
								logOK = false;
							}
		
							if(recv_mode == rxbuf[0]+2){	// 終了コードの判定！！★
								recv_mode = -1;
								if(recv_byte == 0xfe) logOK = true;		// 正常終了
								else                  logOK = false;	// 終了コードが合っていない
							}
							if(recv_mode >= BUFFER_SIZE){	//受信データ数が受信バッファを超えたらリセット
								recv_mode = -1;
								recv_byte = 0;
								recvOK = false;
								logOK = false;
							}
						}
					}										//受信するまでここで待たされる
					catch {
					}


					//シリアルポートから読み取ったバイナリデータを
					//recv_data[]に格納しておく
				//	int		LOG_DATA_SIZE	= 4;	//ログデータのサイズ short=2, float=4
					int		LOG_DATA_SIZE	= 2;	//ログデータのサイズ short=2, float=4
					if(logOK){			//buf[1]から読み取っていく（buf[0]はバイト数）
						int i;
						int rxbuf_p = 1;
						logOK = false;
						
						Camera_N = 32;

						for(i=0; i<Camera_N; i++){
							Camera[i] = rxbuf[rxbuf_p++];
						}
						Camera[i] = Camera[i-1];	// Camera[32] = Camera[31];

						recv_data_n = (LogRecord - Camera_N) / LOG_DATA_SIZE;
						//recv_data[]へのデータ格納（int用）
						for(i=0 ; i < recv_data_n; i++){
							recv_data[i] = BitConverter.ToInt16( rxbuf, rxbuf_p );
							rxbuf_p += 2;
						}

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
//			while(ThreadContinue){
//				time1ms += 10;
//				Thread.Sleep(10);
//			}
		}

		//--------------------------------------------------------------
		//コマンド送信
		public void SendCommand(string cmd){
			if( !serialPort1.IsOpen )
				return;

	//		while( recv_mode != -1 );	//ログ受信中の間は
										//レスポンスモードになるまで待つ



			DateTime startDt, endDt;
			TimeSpan timespan;

			recvOK = false;
			for(int n = 0; n < CommandTimeOut; n++){
				try{
					serialPort1.WriteLine(cmd);
					txtTerm.AppendText(cmd + "\n");

					startDt = DateTime.Now;
					do{
						if(recvOK)
							return;
						endDt = DateTime.Now;
						timespan = endDt - startDt; // 時間の差分を取得
					}while( (int)timespan.TotalMilliseconds < (int)nudCommandWait1.Value );
					
				}
				catch {
				}
			}
		}

		//--------------------------------------------------------------
		//ログデータの読み込み処理（一定期間ごとに呼ばれる）
		private void timerLogView_Tick(object sender, EventArgs e){
			if(!serialPort1.IsOpen)	return;

			now.cam_CenterIndex = (int)recv_data[ 0];
			now.cam_Sens		= (int)recv_data[ 1];
			now.cam_integration = (int)recv_data[ 2];
			now.cam_delay_pulse = (int)recv_data[ 3];
			
			if(chkLog.Checked){
				//リストボックスに受信したデータを表示
				lstBox.Items.Clear();
				lstBox.Items.Add("  0-7, 8-15,16-23,24-31");
				lstBox.Items.Add("-----------------------");
				for(int i=0; i<8; i++){
					lstBox.Items.Add(string.Format("{0,5},{1,5},{2,5},{3,5}",
						Camera[i], Camera[i+8], Camera[i+16], Camera[i+24]));
				}
				lstBox.Items.Add("");

				for(int i=0; i<recv_data_n; i++){
					lstBox.Items.Add(recv_data[i].ToString());
				}

				// テキストボックス txtSens にデジタルセンサ値を表示
				// 最上位ビットは除去する
				String s="";
				int d0 = (int)recv_data[1];
				d0 = ((d0 << 1) & 0xf0) | (d0 & 0x0f);

				byte dd = (byte)(d0 & 0xff);
				for(int j=0; j<8; j++){
					if((dd & 0x80) != 0) s += "1";
					else          s += ".";
					dd <<= 1;
				}
				txtSens.Text = s;

			}
			
			txtGraph0.Text	= recv_data[0].ToString();
			txtGraph1.Text	= recv_data[1].ToString();
			txtGraph2.Text	= recv_data[2].ToString();
			txtGraph3.Text	= recv_data[3].ToString();
		//	txtGraph4.Text	= Camera[4].ToString();
		//	txtGraph5.Text	= Camera[5].ToString();
		//	txtGraph6.Text	= Camera[6].ToString();
		//	txtGraph7.Text	= Camera[7].ToString();
			

//			lstBox.Items.Clear();
//			for(int i=0; i<recv_data_n; i++){
//				lstBox.Items.Add(i + ": " + recv_data[i].ToString());
//			}
		//	lstBox.Items.Add("logOK:" + logOK


			//シリアルポート受信バッファ内のバイト数調査用 BytesToRead
			//受信バッファー内のデータのバイト数を取得します。
			spRcvBufNum2 = serialPort1.BytesToRead;
			if(spRcvBufNum2 > spRcvBufMax2)
				spRcvBufMax2 = spRcvBufNum2;
			lblRecvBufferNum2.Text = spRcvBufNum2.ToString()
								+ " / " + spRcvBufMax2.ToString();
		
			//グラフ描画
			if(chkLog.Checked) DrawGraph();
			if(chkLog.Checked) DrawGraph2();
		}

		//--------------------------------------------------------------
		//グラフの初期化
		void initGraph(){
			bmp  = new Bitmap(pctGraph .Size.Width, pctGraph .Size.Height);
			bmp2 = new Bitmap(pctGraph2.Size.Width, pctGraph2.Size.Height);

			pctGraph.Image = bmp;
			Graphics g = Graphics.FromImage(pctGraph.Image);

		//	pctGraph2.Image = bmp2;
			//g2 = Graphics.FromImage(pctGraph2.Image);

			x0 = pctGraph2.Width / 2;	//中央線
			y0 = pctGraph2.Height / 2;	//水平線
			graph_v = 1;				//xの増分
		
			for(n=0; n<graph_points; n++){
				gp[n].y = gp[n].y1 = y0;
				gp[n].enabled = true;
			//	gp[n].scale = 1.0F;
			}

			gp[ 0].pen = new Pen(Color.Yellow, 1);
			gp[ 1].pen = new Pen(Color.Cyan, 1);
			gp[ 2].pen = new Pen(Color.Lime, 1);
			gp[ 3].pen = new Pen(Color.LightBlue, 1);
			gp[ 4].pen = new Pen(Color.Yellow, 2);
			gp[ 5].pen = new Pen(Color.Blue, 2);
			gp[ 6].pen = new Pen(Color.Green, 2);
			gp[ 7].pen = new Pen(Color.LimeGreen, 1);

			gp[ 0].scale = 10.0F;
			gp[ 1].scale = 1.0F;
			gp[ 2].scale = 1.0F;
			gp[ 3].scale = 1.0F;
			gp[ 4].scale = 1.0F;
			gp[ 5].scale = 1.0F;
			gp[ 6].scale = 1.0F;
			gp[ 7].scale = 0.001F;

			graph_enabled = true;

			g.Dispose();
		}

		//==========================================================================
		// Graphの描画
		//==========================================================================
		public void DrawGraph(){
			Graphics gx = pctGraph.CreateGraphics();
			Graphics g = Graphics.FromImage(bmp);		//BitmapのGraphicsを作成
			int GasoSize = 8;
			int graph_vx = pctGraph.Width / 32;
			int graph_vy = 8;

			//----------------------------------------------------------------------
			if( !graph_enabled ) return;
	
			//----------------------------------------------------------------------
			// クローンBitmapを作成し、1ドットずらす
			//----------------------------------------------------------------------
			Image bmx = (Image)bmp.Clone();
			g.DrawImage(bmx, 0, -GasoSize);

			// 画素
			for(int i = 0; i<32; i++){
				g.FillRectangle(brsh[Camera[i]/16], i*graph_vx, pctGraph.Height-graph_vy, graph_vx, graph_vy);
			}
			g.DrawLine(Pens.Gray,  pctGraph.Width / 2, 0, pctGraph.Width / 2, pctGraph.Height);

			//----------------------------------------------------------------------
			gx.DrawImage(bmp, 0, 0);	//Bitmapの描画結果をPictureBoxに反映
			gx.Dispose();				//Graphicsの解放
			g.Dispose();				//Graphicsの解放
		}

		public void DrawGraph2(){
			int i, scale, scaleY = 1;
			int min_x, min_y, max_x, max_y, center_x;
			//----------------------------------------------------------------------
			if( !graph_enabled ) return;
	
			//----------------------------------------------------------------------
			//g2への描画
			//----------------------------------------------------------------------

			pctGraph2.Image = bmp2;
			g2 = Graphics.FromImage(pctGraph2.Image);

			g2.FillRectangle(Brushes.Navy, 0, 0, pctGraph2.Width, pctGraph2.Height);
	
			//縦線描画
			g2.DrawLine(Pens.Gray,  x0, 0, x0, pctGraph2.Height);
			for(i = x0+32; i < pctGraph2.Width; i += 32){
				g2.DrawLine(Pens.DarkSlateGray, i, 0, i, pctGraph2.Height);
			}
			for(i = x0-32; i > 0; i -= 32){
				g2.DrawLine(Pens.DarkSlateGray, i, 0, i, pctGraph2.Height);
			}

			//横線描画
			g2.DrawLine(Pens.Gray,  0, y0, pctGraph2.Width, y0);
			for(i = y0+32; i < pctGraph2.Height; i += 32){
				g2.DrawLine(Pens.DarkSlateGray, 0, i, pctGraph2.Width, i);
			}
			for(i = y0-32; i > 0; i -= 32){
				g2.DrawLine(Pens.DarkSlateGray, 0, i, pctGraph2.Width, i);
			}

			if(Camera_N > 0) scale = 256 / Camera_N;
			else         scale = 0;

			//Cameraの画像を描画
			Camera2[0] = 128;
			for(i=1; i<Camera_N; i++){
				g2.DrawLine(Pens.Cyan, (i-1)*scale+scale/2, pctGraph2.Height-Camera[i-1]*scaleY, i*scale+scale/2, pctGraph2.Height-Camera[i]*scaleY);

				Camera2[i] = (int)Camera[i]*scaleY - (int)Camera[i-1]*scaleY + 128;
				g2.DrawLine(Pens.Yellow, (i-1)*scale+scale/2, pctGraph2.Height-Camera2[i-1], i*scale+scale/2, pctGraph2.Height-Camera2[i]);
			}

			Camera_min = Camera_max = Camera2[5];
			for(i=6; i<27; i++){
				if(Camera2[i] < Camera_min){
					Camera_min = Camera2[i];
					Camera_min_index = i;
				}
				else if(Camera2[i] > Camera_max){
					Camera_max = Camera2[i];
					Camera_max_index = i;
				}
			}
			Camera_center = (Camera_min + Camera_max) / 2;
			Camera_center_index = (Camera_min_index + Camera_max_index) / 2;

			
			min_x = Camera_min_index * scale;
			min_y = Camera_min;
			max_x = Camera_max_index * scale;
			max_y = Camera_max;
		//	center_x = Camera_center_index * scale;		//now.cam_CenterIndex
			center_x = now.cam_CenterIndex * scale;		//now.cam_CenterIndex  Camera_CenterIndex
			
			g2.DrawLine(Pens.Red, center_x, 0, center_x, pctGraph2.Height);
			g2.DrawEllipse(Pens.Red, min_x-4, pctGraph2.Height-min_y-4, 8, 8);
			g2.DrawEllipse(Pens.Red, max_x-4, pctGraph2.Height-max_y-4, 8, 8);

		}

		private void txtTerm_KeyPress(object sender, KeyPressEventArgs e){
			if(serialPort1.IsOpen){
				byte[] b = new byte[1];
				b[0] = (byte)e.KeyChar;
				serialPort1.Write(b, 0, 1);
			}
		}

		private void btnSendCommand_Click(object sender, EventArgs e)
		{
			bool b = chkLog.Checked;
			if(b) chkLog.Checked = false;
			SendCommand("cInteg=" + nudInteg.Value + ";");
			SendCommand("cDelay=" + nudDelay.Value + ";");
			SendCommand("cDelayAdc=" + nudDelayAdc.Value + ";");
			if(b) chkLog.Checked = true;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			SendCommand("z;");
			serialPort1.DiscardInBuffer();
		}

		private void btnTest_01_Click(object sender, EventArgs e)
		{
			SendCommand("+;");
			lblLogRecordSize.Text = "Logのバイト数 = " + LogRecord.ToString();
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

		private void chkG7_CheckedChanged(object sender, EventArgs e)
		{
			gp[7].enabled = chkG7.Checked;
		}

		private void chkLog_CheckedChanged(object sender, EventArgs e)
		{
			if(chkLog.Checked) SendCommand("d1;");
			else               SendCommand("d0;");
		}

		private void frmMain_Resize(object sender, EventArgs e)
		{
			//グラフの初期化
			initGraph();

		}

		private void rdAcrobatModeSpd_Click(object sender, EventArgs e)
		{
			SendCommand("b0;");
		}

		private void rdAcrobatModePos_Click(object sender, EventArgs e)
		{
			SendCommand("b1;");
		}

		private void nudInteg_ValueChanged(object sender, EventArgs e)
		{
			bool b = chkLog.Checked;
			if(b) chkLog.Checked = false;
			SendCommand("cInteg=" + nudInteg.Value + ";");
			if(b) chkLog.Checked = true;
		}

		private void nudDelay_ValueChanged(object sender, EventArgs e)
		{
			bool b = chkLog.Checked;
			if(b) chkLog.Checked = false;
			SendCommand("cDelay=" + nudDelay.Value + ";");
			if(b) chkLog.Checked = true;
		}

		private void nudDelayAdc_ValueChanged(object sender, EventArgs e)
		{
			bool b = chkLog.Checked;
			if(b) chkLog.Checked = false;
			SendCommand("cDelayAdc=" + nudDelayAdc.Value + ";");
			if(b) chkLog.Checked = true;
		}


	}
}
