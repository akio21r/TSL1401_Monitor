namespace InvertedPendulumControl
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.pnlCTL = new System.Windows.Forms.Panel();
			this.lstBox = new System.Windows.Forms.ListBox();
			this.txtRecv = new System.Windows.Forms.TextBox();
			this.txtTerm = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtTR = new System.Windows.Forms.TextBox();
			this.txtTF = new System.Windows.Forms.TextBox();
			this.txtWB = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.chkRecvFlag = new System.Windows.Forms.CheckBox();
			this.chkRecvOK = new System.Windows.Forms.CheckBox();
			this.lblPortConnect = new System.Windows.Forms.Label();
			this.btnDisConnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.cmbBaudRate = new System.Windows.Forms.ComboBox();
			this.cmbPort = new System.Windows.Forms.ComboBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.pnlView = new System.Windows.Forms.Panel();
			this.label24 = new System.Windows.Forms.Label();
			this.lblRecvNum = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtViewPower = new System.Windows.Forms.TextBox();
			this.btnSendParam = new System.Windows.Forms.Button();
			this.txtF5 = new System.Windows.Forms.TextBox();
			this.txtF4 = new System.Windows.Forms.TextBox();
			this.btnTestA = new System.Windows.Forms.Button();
			this.txtF3 = new System.Windows.Forms.TextBox();
			this.txtF2 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtF1 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtAngle = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSpeedR = new System.Windows.Forms.TextBox();
			this.txtEncR = new System.Windows.Forms.TextBox();
			this.txtAccel = new System.Windows.Forms.TextBox();
			this.txtSpeedL = new System.Windows.Forms.TextBox();
			this.txtEncL = new System.Windows.Forms.TextBox();
			this.txtGyro = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlSet = new System.Windows.Forms.Panel();
			this.label23 = new System.Windows.Forms.Label();
			this.btnAllMotorStop = new System.Windows.Forms.Button();
			this.chkModePowerAll = new System.Windows.Forms.CheckBox();
			this.chkModePower = new System.Windows.Forms.CheckBox();
			this.trackBarPower = new System.Windows.Forms.TrackBar();
			this.trackBarHandle = new System.Windows.Forms.TrackBar();
			this.nudSetPower = new System.Windows.Forms.NumericUpDown();
			this.nudSetAngle = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.chkSetFreeFR = new System.Windows.Forms.CheckBox();
			this.chkSetFreeRR = new System.Windows.Forms.CheckBox();
			this.chkSetFreeRL = new System.Windows.Forms.CheckBox();
			this.chkSetTrace = new System.Windows.Forms.CheckBox();
			this.chkSetFreeFL = new System.Windows.Forms.CheckBox();
			this.nudSetV = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudSetRR = new System.Windows.Forms.NumericUpDown();
			this.nudSetMR = new System.Windows.Forms.NumericUpDown();
			this.nudSetRL = new System.Windows.Forms.NumericUpDown();
			this.nudSetML = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.pctGraph = new System.Windows.Forms.PictureBox();
			this.pnlGraph = new System.Windows.Forms.Panel();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.timerLogView = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.btnReset = new System.Windows.Forms.Button();
			this.pnlCTL.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlView.SuspendLayout();
			this.pnlSet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHandle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetPower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetRR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetMR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetRL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetML)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctGraph)).BeginInit();
			this.pnlGraph.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCTL
			// 
			this.pnlCTL.Controls.Add(this.lstBox);
			this.pnlCTL.Controls.Add(this.txtRecv);
			this.pnlCTL.Controls.Add(this.txtTerm);
			this.pnlCTL.Controls.Add(this.panel1);
			this.pnlCTL.Controls.Add(this.pnlView);
			this.pnlCTL.Controls.Add(this.label2);
			this.pnlCTL.Controls.Add(this.pnlSet);
			this.pnlCTL.Controls.Add(this.label1);
			this.pnlCTL.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCTL.Location = new System.Drawing.Point(0, 0);
			this.pnlCTL.Name = "pnlCTL";
			this.pnlCTL.Size = new System.Drawing.Size(1060, 356);
			this.pnlCTL.TabIndex = 5;
			// 
			// lstBox
			// 
			this.lstBox.BackColor = System.Drawing.Color.Navy;
			this.lstBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lstBox.ForeColor = System.Drawing.Color.White;
			this.lstBox.FormattingEnabled = true;
			this.lstBox.ItemHeight = 12;
			this.lstBox.Location = new System.Drawing.Point(217, 24);
			this.lstBox.Name = "lstBox";
			this.lstBox.Size = new System.Drawing.Size(158, 304);
			this.lstBox.TabIndex = 18;
			// 
			// txtRecv
			// 
			this.txtRecv.BackColor = System.Drawing.Color.Navy;
			this.txtRecv.ForeColor = System.Drawing.Color.White;
			this.txtRecv.Location = new System.Drawing.Point(3, 335);
			this.txtRecv.Name = "txtRecv";
			this.txtRecv.Size = new System.Drawing.Size(606, 19);
			this.txtRecv.TabIndex = 4;
			// 
			// txtTerm
			// 
			this.txtTerm.BackColor = System.Drawing.Color.Navy;
			this.txtTerm.ForeColor = System.Drawing.Color.White;
			this.txtTerm.Location = new System.Drawing.Point(5, 24);
			this.txtTerm.Multiline = true;
			this.txtTerm.Name = "txtTerm";
			this.txtTerm.Size = new System.Drawing.Size(206, 304);
			this.txtTerm.TabIndex = 3;
			this.txtTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerm_KeyPress);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtTR);
			this.panel1.Controls.Add(this.txtTF);
			this.panel1.Controls.Add(this.txtWB);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.chkRecvFlag);
			this.panel1.Controls.Add(this.chkRecvOK);
			this.panel1.Controls.Add(this.lblPortConnect);
			this.panel1.Controls.Add(this.btnDisConnect);
			this.panel1.Controls.Add(this.btnConnect);
			this.panel1.Controls.Add(this.cmbBaudRate);
			this.panel1.Controls.Add(this.cmbPort);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Controls.Add(this.btnStop);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Location = new System.Drawing.Point(867, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(186, 332);
			this.panel1.TabIndex = 17;
			// 
			// txtTR
			// 
			this.txtTR.Location = new System.Drawing.Point(82, 268);
			this.txtTR.Name = "txtTR";
			this.txtTR.Size = new System.Drawing.Size(42, 19);
			this.txtTR.TabIndex = 27;
			this.txtTR.Text = "170";
			// 
			// txtTF
			// 
			this.txtTF.Location = new System.Drawing.Point(82, 243);
			this.txtTF.Name = "txtTF";
			this.txtTF.Size = new System.Drawing.Size(42, 19);
			this.txtTF.TabIndex = 27;
			this.txtTF.Text = "150";
			// 
			// txtWB
			// 
			this.txtWB.Location = new System.Drawing.Point(82, 218);
			this.txtWB.Name = "txtWB";
			this.txtWB.Size = new System.Drawing.Size(42, 19);
			this.txtWB.TabIndex = 27;
			this.txtWB.Text = "165";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(30, 271);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(46, 12);
			this.label22.TabIndex = 26;
			this.label22.Text = "Rトレッド";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(31, 246);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(45, 12);
			this.label21.TabIndex = 26;
			this.label21.Text = "Fトレッド";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(3, 218);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(73, 12);
			this.label20.TabIndex = 26;
			this.label20.Text = "ホイールベース";
			// 
			// chkRecvFlag
			// 
			this.chkRecvFlag.AutoSize = true;
			this.chkRecvFlag.Location = new System.Drawing.Point(5, 175);
			this.chkRecvFlag.Name = "chkRecvFlag";
			this.chkRecvFlag.Size = new System.Drawing.Size(72, 16);
			this.chkRecvFlag.TabIndex = 5;
			this.chkRecvFlag.Text = "RecvFlag";
			this.chkRecvFlag.UseVisualStyleBackColor = true;
			// 
			// chkRecvOK
			// 
			this.chkRecvOK.AutoSize = true;
			this.chkRecvOK.Location = new System.Drawing.Point(5, 153);
			this.chkRecvOK.Name = "chkRecvOK";
			this.chkRecvOK.Size = new System.Drawing.Size(65, 16);
			this.chkRecvOK.TabIndex = 5;
			this.chkRecvOK.Text = "RecvOK";
			this.chkRecvOK.UseVisualStyleBackColor = true;
			// 
			// lblPortConnect
			// 
			this.lblPortConnect.AutoSize = true;
			this.lblPortConnect.Location = new System.Drawing.Point(86, 93);
			this.lblPortConnect.Name = "lblPortConnect";
			this.lblPortConnect.Size = new System.Drawing.Size(47, 12);
			this.lblPortConnect.TabIndex = 4;
			this.lblPortConnect.Text = "・・・切断";
			// 
			// btnDisConnect
			// 
			this.btnDisConnect.Location = new System.Drawing.Point(3, 116);
			this.btnDisConnect.Name = "btnDisConnect";
			this.btnDisConnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisConnect.TabIndex = 3;
			this.btnDisConnect.Text = "切断";
			this.btnDisConnect.UseVisualStyleBackColor = true;
			this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(5, 87);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = "接続";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// cmbBaudRate
			// 
			this.cmbBaudRate.FormattingEnabled = true;
			this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
			this.cmbBaudRate.Location = new System.Drawing.Point(3, 61);
			this.cmbBaudRate.Name = "cmbBaudRate";
			this.cmbBaudRate.Size = new System.Drawing.Size(98, 20);
			this.cmbBaudRate.TabIndex = 1;
			this.cmbBaudRate.Text = "115200";
			// 
			// cmbPort
			// 
			this.cmbPort.FormattingEnabled = true;
			this.cmbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12"});
			this.cmbPort.Location = new System.Drawing.Point(3, 18);
			this.cmbPort.Name = "cmbPort";
			this.cmbPort.Size = new System.Drawing.Size(98, 20);
			this.cmbPort.TabIndex = 1;
			this.cmbPort.Text = "COM2";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(117, 116);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(63, 26);
			this.btnStart.TabIndex = 25;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(117, 148);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(63, 26);
			this.btnStop.TabIndex = 25;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 46);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(52, 12);
			this.label17.TabIndex = 0;
			this.label17.Text = "ボーレート";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 3);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(69, 12);
			this.label16.TabIndex = 0;
			this.label16.Text = "シリアルポート";
			// 
			// pnlView
			// 
			this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlView.Controls.Add(this.label24);
			this.pnlView.Controls.Add(this.lblRecvNum);
			this.pnlView.Controls.Add(this.checkBox1);
			this.pnlView.Controls.Add(this.txtViewPower);
			this.pnlView.Controls.Add(this.btnSendParam);
			this.pnlView.Controls.Add(this.txtF5);
			this.pnlView.Controls.Add(this.txtF4);
			this.pnlView.Controls.Add(this.btnTestA);
			this.pnlView.Controls.Add(this.txtF3);
			this.pnlView.Controls.Add(this.txtF2);
			this.pnlView.Controls.Add(this.label29);
			this.pnlView.Controls.Add(this.label13);
			this.pnlView.Controls.Add(this.txtF1);
			this.pnlView.Controls.Add(this.label12);
			this.pnlView.Controls.Add(this.txtAngle);
			this.pnlView.Controls.Add(this.label11);
			this.pnlView.Controls.Add(this.txtSpeedR);
			this.pnlView.Controls.Add(this.txtEncR);
			this.pnlView.Controls.Add(this.txtAccel);
			this.pnlView.Controls.Add(this.txtSpeedL);
			this.pnlView.Controls.Add(this.txtEncL);
			this.pnlView.Controls.Add(this.txtGyro);
			this.pnlView.Controls.Add(this.label10);
			this.pnlView.Controls.Add(this.label19);
			this.pnlView.Controls.Add(this.label9);
			this.pnlView.Controls.Add(this.label28);
			this.pnlView.Controls.Add(this.label27);
			this.pnlView.Controls.Add(this.label26);
			this.pnlView.Controls.Add(this.label25);
			this.pnlView.Controls.Add(this.label15);
			this.pnlView.Controls.Add(this.label8);
			this.pnlView.Location = new System.Drawing.Point(619, 12);
			this.pnlView.Name = "pnlView";
			this.pnlView.Size = new System.Drawing.Size(242, 332);
			this.pnlView.TabIndex = 16;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(131, 218);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 12);
			this.label24.TabIndex = 33;
			this.label24.Text = "RecvNum:";
			// 
			// lblRecvNum
			// 
			this.lblRecvNum.AutoSize = true;
			this.lblRecvNum.Location = new System.Drawing.Point(187, 217);
			this.lblRecvNum.Name = "lblRecvNum";
			this.lblRecvNum.Size = new System.Drawing.Size(11, 12);
			this.lblRecvNum.TabIndex = 33;
			this.lblRecvNum.Text = "0";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(11, 301);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 16);
			this.checkBox1.TabIndex = 32;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// txtViewPower
			// 
			this.txtViewPower.Location = new System.Drawing.Point(133, 150);
			this.txtViewPower.Name = "txtViewPower";
			this.txtViewPower.Size = new System.Drawing.Size(60, 19);
			this.txtViewPower.TabIndex = 28;
			// 
			// btnSendParam
			// 
			this.btnSendParam.Location = new System.Drawing.Point(101, 243);
			this.btnSendParam.Name = "btnSendParam";
			this.btnSendParam.Size = new System.Drawing.Size(127, 79);
			this.btnSendParam.TabIndex = 27;
			this.btnSendParam.Text = "パラメータ送信";
			this.btnSendParam.UseVisualStyleBackColor = true;
			this.btnSendParam.Click += new System.EventHandler(this.btnSendCommand_Click);
			// 
			// txtF5
			// 
			this.txtF5.Location = new System.Drawing.Point(33, 276);
			this.txtF5.Name = "txtF5";
			this.txtF5.Size = new System.Drawing.Size(60, 19);
			this.txtF5.TabIndex = 2;
			this.txtF5.Text = "0";
			// 
			// txtF4
			// 
			this.txtF4.Location = new System.Drawing.Point(33, 251);
			this.txtF4.Name = "txtF4";
			this.txtF4.Size = new System.Drawing.Size(60, 19);
			this.txtF4.TabIndex = 2;
			this.txtF4.Text = "0";
			// 
			// btnTestA
			// 
			this.btnTestA.Location = new System.Drawing.Point(133, 179);
			this.btnTestA.Name = "btnTestA";
			this.btnTestA.Size = new System.Drawing.Size(74, 26);
			this.btnTestA.TabIndex = 27;
			this.btnTestA.Text = "TestA";
			this.btnTestA.UseVisualStyleBackColor = true;
			this.btnTestA.Click += new System.EventHandler(this.btnTestA_Click);
			// 
			// txtF3
			// 
			this.txtF3.Location = new System.Drawing.Point(33, 226);
			this.txtF3.Name = "txtF3";
			this.txtF3.Size = new System.Drawing.Size(60, 19);
			this.txtF3.TabIndex = 2;
			this.txtF3.Text = "0";
			// 
			// txtF2
			// 
			this.txtF2.Location = new System.Drawing.Point(33, 201);
			this.txtF2.Name = "txtF2";
			this.txtF2.Size = new System.Drawing.Size(60, 19);
			this.txtF2.TabIndex = 2;
			this.txtF2.Text = "0";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(9, 279);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(18, 12);
			this.label29.TabIndex = 0;
			this.label29.Text = "F5";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 254);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(18, 12);
			this.label13.TabIndex = 0;
			this.label13.Text = "F4";
			// 
			// txtF1
			// 
			this.txtF1.Location = new System.Drawing.Point(33, 176);
			this.txtF1.Name = "txtF1";
			this.txtF1.Size = new System.Drawing.Size(60, 19);
			this.txtF1.TabIndex = 2;
			this.txtF1.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(9, 229);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(18, 12);
			this.label12.TabIndex = 0;
			this.label12.Text = "F3";
			// 
			// txtAngle
			// 
			this.txtAngle.Location = new System.Drawing.Point(56, 125);
			this.txtAngle.Name = "txtAngle";
			this.txtAngle.Size = new System.Drawing.Size(137, 19);
			this.txtAngle.TabIndex = 2;
			this.txtAngle.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 204);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(18, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "F2";
			// 
			// txtSpeedR
			// 
			this.txtSpeedR.Location = new System.Drawing.Point(126, 107);
			this.txtSpeedR.Name = "txtSpeedR";
			this.txtSpeedR.Size = new System.Drawing.Size(60, 19);
			this.txtSpeedR.TabIndex = 2;
			this.txtSpeedR.Text = "0";
			// 
			// txtEncR
			// 
			this.txtEncR.Location = new System.Drawing.Point(126, 72);
			this.txtEncR.Name = "txtEncR";
			this.txtEncR.Size = new System.Drawing.Size(60, 19);
			this.txtEncR.TabIndex = 2;
			this.txtEncR.Text = "0";
			// 
			// txtAccel
			// 
			this.txtAccel.Location = new System.Drawing.Point(126, 35);
			this.txtAccel.Name = "txtAccel";
			this.txtAccel.Size = new System.Drawing.Size(60, 19);
			this.txtAccel.TabIndex = 2;
			this.txtAccel.Text = "0";
			// 
			// txtSpeedL
			// 
			this.txtSpeedL.Location = new System.Drawing.Point(14, 107);
			this.txtSpeedL.Name = "txtSpeedL";
			this.txtSpeedL.Size = new System.Drawing.Size(60, 19);
			this.txtSpeedL.TabIndex = 2;
			this.txtSpeedL.Text = "0";
			// 
			// txtEncL
			// 
			this.txtEncL.Location = new System.Drawing.Point(14, 72);
			this.txtEncL.Name = "txtEncL";
			this.txtEncL.Size = new System.Drawing.Size(60, 19);
			this.txtEncL.TabIndex = 2;
			this.txtEncL.Text = "0";
			// 
			// txtGyro
			// 
			this.txtGyro.Location = new System.Drawing.Point(14, 35);
			this.txtGyro.Name = "txtGyro";
			this.txtGyro.Size = new System.Drawing.Size(60, 19);
			this.txtGyro.TabIndex = 2;
			this.txtGyro.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 179);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 12);
			this.label10.TabIndex = 0;
			this.label10.Text = "F1";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(57, 153);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(70, 12);
			this.label19.TabIndex = 0;
			this.label19.Text = "モータ出力[%]";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(18, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "angle";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(124, 92);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(48, 12);
			this.label28.TabIndex = 0;
			this.label28.Text = "Speed_R";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(12, 92);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(46, 12);
			this.label27.TabIndex = 0;
			this.label27.Text = "Speed_L";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(124, 57);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(36, 12);
			this.label26.TabIndex = 0;
			this.label26.Text = "Enc_R";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(12, 57);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(34, 12);
			this.label25.TabIndex = 0;
			this.label25.Text = "Enc_L";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(124, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 12);
			this.label15.TabIndex = 0;
			this.label15.Text = "加速度センサ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 12);
			this.label8.TabIndex = 0;
			this.label8.Text = "ジャイロセンサ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(215, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Receive Text";
			// 
			// pnlSet
			// 
			this.pnlSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlSet.Controls.Add(this.label23);
			this.pnlSet.Controls.Add(this.btnAllMotorStop);
			this.pnlSet.Controls.Add(this.chkModePowerAll);
			this.pnlSet.Controls.Add(this.chkModePower);
			this.pnlSet.Controls.Add(this.trackBarPower);
			this.pnlSet.Controls.Add(this.trackBarHandle);
			this.pnlSet.Controls.Add(this.nudSetPower);
			this.pnlSet.Controls.Add(this.nudSetAngle);
			this.pnlSet.Controls.Add(this.label14);
			this.pnlSet.Controls.Add(this.chkSetFreeFR);
			this.pnlSet.Controls.Add(this.chkSetFreeRR);
			this.pnlSet.Controls.Add(this.chkSetFreeRL);
			this.pnlSet.Controls.Add(this.chkSetTrace);
			this.pnlSet.Controls.Add(this.chkSetFreeFL);
			this.pnlSet.Controls.Add(this.nudSetV);
			this.pnlSet.Controls.Add(this.label6);
			this.pnlSet.Controls.Add(this.label5);
			this.pnlSet.Controls.Add(this.label4);
			this.pnlSet.Controls.Add(this.label18);
			this.pnlSet.Controls.Add(this.label7);
			this.pnlSet.Controls.Add(this.label3);
			this.pnlSet.Controls.Add(this.nudSetRR);
			this.pnlSet.Controls.Add(this.nudSetMR);
			this.pnlSet.Controls.Add(this.nudSetRL);
			this.pnlSet.Controls.Add(this.nudSetML);
			this.pnlSet.Location = new System.Drawing.Point(377, 12);
			this.pnlSet.Name = "pnlSet";
			this.pnlSet.Size = new System.Drawing.Size(236, 332);
			this.pnlSet.TabIndex = 15;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(110, 261);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(67, 12);
			this.label23.TabIndex = 32;
			this.label23.Text = "←SpaceKey";
			// 
			// btnAllMotorStop
			// 
			this.btnAllMotorStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAllMotorStop.Location = new System.Drawing.Point(17, 248);
			this.btnAllMotorStop.Name = "btnAllMotorStop";
			this.btnAllMotorStop.Size = new System.Drawing.Size(87, 32);
			this.btnAllMotorStop.TabIndex = 31;
			this.btnAllMotorStop.Text = "全モータ停止";
			this.btnAllMotorStop.UseVisualStyleBackColor = true;
			this.btnAllMotorStop.Click += new System.EventHandler(this.btnAllMotorStop_Click);
			// 
			// chkModePowerAll
			// 
			this.chkModePowerAll.AutoSize = true;
			this.chkModePowerAll.Location = new System.Drawing.Point(17, 108);
			this.chkModePowerAll.Name = "chkModePowerAll";
			this.chkModePowerAll.Size = new System.Drawing.Size(151, 16);
			this.chkModePowerAll.TabIndex = 30;
			this.chkModePowerAll.Text = "モータ出力個別指定モード";
			this.chkModePowerAll.UseVisualStyleBackColor = true;
			this.chkModePowerAll.CheckedChanged += new System.EventHandler(this.chkModePowerAll_CheckedChanged);
			// 
			// chkModePower
			// 
			this.chkModePower.AutoSize = true;
			this.chkModePower.Checked = true;
			this.chkModePower.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkModePower.Location = new System.Drawing.Point(17, 93);
			this.chkModePower.Name = "chkModePower";
			this.chkModePower.Size = new System.Drawing.Size(127, 16);
			this.chkModePower.TabIndex = 30;
			this.chkModePower.Text = "モータ出力指定モード";
			this.chkModePower.UseVisualStyleBackColor = true;
			this.chkModePower.CheckedChanged += new System.EventHandler(this.chkModePower_CheckedChanged);
			// 
			// trackBarPower
			// 
			this.trackBarPower.BackColor = System.Drawing.Color.Teal;
			this.trackBarPower.Location = new System.Drawing.Point(180, 43);
			this.trackBarPower.Maximum = 100;
			this.trackBarPower.Name = "trackBarPower";
			this.trackBarPower.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarPower.Size = new System.Drawing.Size(45, 274);
			this.trackBarPower.TabIndex = 19;
			this.trackBarPower.TickFrequency = 10;
			this.trackBarPower.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBarPower.Scroll += new System.EventHandler(this.trackBarPower_Scroll);
			// 
			// trackBarHandle
			// 
			this.trackBarHandle.BackColor = System.Drawing.Color.Teal;
			this.trackBarHandle.Location = new System.Drawing.Point(5, 43);
			this.trackBarHandle.Maximum = 50;
			this.trackBarHandle.Minimum = -50;
			this.trackBarHandle.Name = "trackBarHandle";
			this.trackBarHandle.Size = new System.Drawing.Size(160, 45);
			this.trackBarHandle.TabIndex = 29;
			this.trackBarHandle.TickFrequency = 10;
			this.trackBarHandle.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBarHandle.Scroll += new System.EventHandler(this.trackBarHandle_Scroll);
			// 
			// nudSetPower
			// 
			this.nudSetPower.Location = new System.Drawing.Point(180, 18);
			this.nudSetPower.Name = "nudSetPower";
			this.nudSetPower.Size = new System.Drawing.Size(45, 19);
			this.nudSetPower.TabIndex = 23;
			this.nudSetPower.ValueChanged += new System.EventHandler(this.nudSetPower_ValueChanged);
			// 
			// nudSetAngle
			// 
			this.nudSetAngle.Location = new System.Drawing.Point(3, 18);
			this.nudSetAngle.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudSetAngle.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
			this.nudSetAngle.Name = "nudSetAngle";
			this.nudSetAngle.Size = new System.Drawing.Size(59, 19);
			this.nudSetAngle.TabIndex = 23;
			this.nudSetAngle.ValueChanged += new System.EventHandler(this.nudSetAngle_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(32, 283);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 12);
			this.label14.TabIndex = 26;
			this.label14.Text = "目標速度 x10[m/s]";
			// 
			// chkSetFreeFR
			// 
			this.chkSetFreeFR.AutoSize = true;
			this.chkSetFreeFR.Location = new System.Drawing.Point(82, 167);
			this.chkSetFreeFR.Name = "chkSetFreeFR";
			this.chkSetFreeFR.Size = new System.Drawing.Size(47, 16);
			this.chkSetFreeFR.TabIndex = 24;
			this.chkSetFreeFR.Text = "Free";
			this.chkSetFreeFR.UseVisualStyleBackColor = true;
			// 
			// chkSetFreeRR
			// 
			this.chkSetFreeRR.AutoSize = true;
			this.chkSetFreeRR.Location = new System.Drawing.Point(82, 226);
			this.chkSetFreeRR.Name = "chkSetFreeRR";
			this.chkSetFreeRR.Size = new System.Drawing.Size(47, 16);
			this.chkSetFreeRR.TabIndex = 24;
			this.chkSetFreeRR.Text = "Free";
			this.chkSetFreeRR.UseVisualStyleBackColor = true;
			// 
			// chkSetFreeRL
			// 
			this.chkSetFreeRL.AutoSize = true;
			this.chkSetFreeRL.Location = new System.Drawing.Point(17, 226);
			this.chkSetFreeRL.Name = "chkSetFreeRL";
			this.chkSetFreeRL.Size = new System.Drawing.Size(47, 16);
			this.chkSetFreeRL.TabIndex = 24;
			this.chkSetFreeRL.Text = "Free";
			this.chkSetFreeRL.UseVisualStyleBackColor = true;
			// 
			// chkSetTrace
			// 
			this.chkSetTrace.AutoSize = true;
			this.chkSetTrace.Location = new System.Drawing.Point(68, 19);
			this.chkSetTrace.Name = "chkSetTrace";
			this.chkSetTrace.Size = new System.Drawing.Size(53, 16);
			this.chkSetTrace.TabIndex = 24;
			this.chkSetTrace.Text = "Trace";
			this.chkSetTrace.UseVisualStyleBackColor = true;
			this.chkSetTrace.Click += new System.EventHandler(this.chkSetTrace_Click);
			// 
			// chkSetFreeFL
			// 
			this.chkSetFreeFL.AutoSize = true;
			this.chkSetFreeFL.Location = new System.Drawing.Point(17, 167);
			this.chkSetFreeFL.Name = "chkSetFreeFL";
			this.chkSetFreeFL.Size = new System.Drawing.Size(47, 16);
			this.chkSetFreeFL.TabIndex = 24;
			this.chkSetFreeFL.Text = "Free";
			this.chkSetFreeFL.UseVisualStyleBackColor = true;
			this.chkSetFreeFL.CheckedChanged += new System.EventHandler(this.chkSetFreeAll_CheckedChanged);
			// 
			// nudSetV
			// 
			this.nudSetV.Location = new System.Drawing.Point(34, 298);
			this.nudSetV.Name = "nudSetV";
			this.nudSetV.Size = new System.Drawing.Size(60, 19);
			this.nudSetV.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(123, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 12);
			this.label6.TabIndex = 19;
			this.label6.Text = "---";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 12);
			this.label5.TabIndex = 20;
			this.label5.Text = "---";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(105, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 12);
			this.label4.TabIndex = 21;
			this.label4.Text = "Mot_R";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(165, 3);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(70, 12);
			this.label18.TabIndex = 22;
			this.label18.Text = "モータ出力[%]";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 12);
			this.label7.TabIndex = 22;
			this.label7.Text = "指定ハンドル角[°]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 12);
			this.label3.TabIndex = 22;
			this.label3.Text = "Mot_L";
			// 
			// nudSetRR
			// 
			this.nudSetRR.Enabled = false;
			this.nudSetRR.Location = new System.Drawing.Point(82, 201);
			this.nudSetRR.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudSetRR.Name = "nudSetRR";
			this.nudSetRR.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.nudSetRR.Size = new System.Drawing.Size(59, 19);
			this.nudSetRR.TabIndex = 16;
			this.nudSetRR.ValueChanged += new System.EventHandler(this.nudSetAllMotor_ValueChanged);
			// 
			// nudSetMR
			// 
			this.nudSetMR.Enabled = false;
			this.nudSetMR.Location = new System.Drawing.Point(82, 142);
			this.nudSetMR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudSetMR.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.nudSetMR.Name = "nudSetMR";
			this.nudSetMR.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.nudSetMR.Size = new System.Drawing.Size(59, 19);
			this.nudSetMR.TabIndex = 15;
			this.nudSetMR.ValueChanged += new System.EventHandler(this.nudSetAllMotor_ValueChanged);
			// 
			// nudSetRL
			// 
			this.nudSetRL.Enabled = false;
			this.nudSetRL.Location = new System.Drawing.Point(17, 201);
			this.nudSetRL.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudSetRL.Name = "nudSetRL";
			this.nudSetRL.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.nudSetRL.Size = new System.Drawing.Size(59, 19);
			this.nudSetRL.TabIndex = 17;
			this.nudSetRL.ValueChanged += new System.EventHandler(this.nudSetAllMotor_ValueChanged);
			// 
			// nudSetML
			// 
			this.nudSetML.Enabled = false;
			this.nudSetML.Location = new System.Drawing.Point(17, 142);
			this.nudSetML.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudSetML.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.nudSetML.Name = "nudSetML";
			this.nudSetML.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.nudSetML.Size = new System.Drawing.Size(59, 19);
			this.nudSetML.TabIndex = 18;
			this.nudSetML.ValueChanged += new System.EventHandler(this.nudSetAllMotor_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "Terminal";
			// 
			// pctGraph
			// 
			this.pctGraph.BackColor = System.Drawing.Color.Navy;
			this.pctGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pctGraph.Location = new System.Drawing.Point(0, 0);
			this.pctGraph.Margin = new System.Windows.Forms.Padding(30);
			this.pctGraph.Name = "pctGraph";
			this.pctGraph.Size = new System.Drawing.Size(1056, 241);
			this.pctGraph.TabIndex = 8;
			this.pctGraph.TabStop = false;
			// 
			// pnlGraph
			// 
			this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlGraph.Controls.Add(this.pctGraph);
			this.pnlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGraph.Location = new System.Drawing.Point(0, 356);
			this.pnlGraph.Name = "pnlGraph";
			this.pnlGraph.Size = new System.Drawing.Size(1060, 245);
			this.pnlGraph.TabIndex = 9;
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.PortName = "COM4";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// timerLogView
			// 
			this.timerLogView.Enabled = true;
			this.timerLogView.Tick += new System.EventHandler(this.timerLogView_Tick);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(117, 180);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(63, 26);
			this.btnReset.TabIndex = 25;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnSendParam;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAllMotorStop;
			this.ClientSize = new System.Drawing.Size(1060, 601);
			this.Controls.Add(this.pnlGraph);
			this.Controls.Add(this.pnlCTL);
			this.Name = "frmMain";
			this.Text = "MCRControlMonitor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
			this.pnlCTL.ResumeLayout(false);
			this.pnlCTL.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlView.ResumeLayout(false);
			this.pnlView.PerformLayout();
			this.pnlSet.ResumeLayout(false);
			this.pnlSet.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarPower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHandle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetPower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetRR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetMR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetRL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetML)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctGraph)).EndInit();
			this.pnlGraph.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTL;
        private System.Windows.Forms.Panel pnlSet;
        private System.Windows.Forms.CheckBox chkSetFreeFR;
        private System.Windows.Forms.CheckBox chkSetFreeRR;
        private System.Windows.Forms.CheckBox chkSetFreeRL;
        private System.Windows.Forms.CheckBox chkSetFreeFL;
        private System.Windows.Forms.NumericUpDown nudSetAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSetRR;
        private System.Windows.Forms.NumericUpDown nudSetMR;
        private System.Windows.Forms.NumericUpDown nudSetRL;
        private System.Windows.Forms.NumericUpDown nudSetML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtF4;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGyro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudSetV;
        private System.Windows.Forms.TextBox txtAccel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkSetTrace;
        private System.Windows.Forms.PictureBox pctGraph;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblPortConnect;
		private System.Windows.Forms.Button btnTestA;
		private System.Windows.Forms.Button btnSendParam;
		private System.Windows.Forms.NumericUpDown nudSetPower;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtViewPower;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TrackBar trackBarHandle;
		private System.Windows.Forms.TrackBar trackBarPower;
		private System.Windows.Forms.Timer timerLogView;
		private System.Windows.Forms.CheckBox chkModePowerAll;
		private System.Windows.Forms.CheckBox chkModePower;
		private System.Windows.Forms.CheckBox chkRecvFlag;
		private System.Windows.Forms.CheckBox chkRecvOK;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Button btnAllMotorStop;
		private System.Windows.Forms.TextBox txtTR;
		private System.Windows.Forms.TextBox txtTF;
		private System.Windows.Forms.TextBox txtWB;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lblRecvNum;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ListBox lstBox;
		private System.Windows.Forms.TextBox txtSpeedR;
		private System.Windows.Forms.TextBox txtEncR;
		private System.Windows.Forms.TextBox txtSpeedL;
		private System.Windows.Forms.TextBox txtEncL;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtF5;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Button btnReset;

    }
}

