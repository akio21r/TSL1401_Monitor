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
			this.lblSens = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.lblRecvNum = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnMotorAllCopy = new System.Windows.Forms.Button();
			this.txtViewPower = new System.Windows.Forms.TextBox();
			this.btnTestB = new System.Windows.Forms.Button();
			this.txtViewRR = new System.Windows.Forms.TextBox();
			this.btnTestA = new System.Windows.Forms.Button();
			this.txtViewRL = new System.Windows.Forms.TextBox();
			this.txtViewFR = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtViewFL = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtViewAngle = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtViewVMax = new System.Windows.Forms.TextBox();
			this.txtViewV = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
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
			this.nudSetFR = new System.Windows.Forms.NumericUpDown();
			this.nudSetRL = new System.Windows.Forms.NumericUpDown();
			this.nudSetFL = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.pctGraph = new System.Windows.Forms.PictureBox();
			this.pnlGraph = new System.Windows.Forms.Panel();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.timerLogView = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
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
			((System.ComponentModel.ISupportInitialize)(this.nudSetFR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetRL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetFL)).BeginInit();
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
			this.pnlCTL.Size = new System.Drawing.Size(1060, 354);
			this.pnlCTL.TabIndex = 5;
			// 
			// lstBox
			// 
			this.lstBox.BackColor = System.Drawing.Color.Navy;
			this.lstBox.ForeColor = System.Drawing.Color.White;
			this.lstBox.FormattingEnabled = true;
			this.lstBox.ItemHeight = 12;
			this.lstBox.Location = new System.Drawing.Point(5, 229);
			this.lstBox.Name = "lstBox";
			this.lstBox.Size = new System.Drawing.Size(366, 100);
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
			this.txtTerm.Size = new System.Drawing.Size(366, 187);
			this.txtTerm.TabIndex = 3;
			this.txtTerm.TextChanged += new System.EventHandler(this.txtTerm_TextChanged);
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
			this.btnStart.Location = new System.Drawing.Point(117, 135);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(63, 26);
			this.btnStart.TabIndex = 25;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(117, 167);
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
			this.pnlView.Controls.Add(this.lblSens);
			this.pnlView.Controls.Add(this.label24);
			this.pnlView.Controls.Add(this.lblRecvNum);
			this.pnlView.Controls.Add(this.checkBox1);
			this.pnlView.Controls.Add(this.btnMotorAllCopy);
			this.pnlView.Controls.Add(this.txtViewPower);
			this.pnlView.Controls.Add(this.btnTestB);
			this.pnlView.Controls.Add(this.txtViewRR);
			this.pnlView.Controls.Add(this.btnTestA);
			this.pnlView.Controls.Add(this.txtViewRL);
			this.pnlView.Controls.Add(this.txtViewFR);
			this.pnlView.Controls.Add(this.label13);
			this.pnlView.Controls.Add(this.txtViewFL);
			this.pnlView.Controls.Add(this.label12);
			this.pnlView.Controls.Add(this.txtViewAngle);
			this.pnlView.Controls.Add(this.label11);
			this.pnlView.Controls.Add(this.txtViewVMax);
			this.pnlView.Controls.Add(this.txtViewV);
			this.pnlView.Controls.Add(this.label10);
			this.pnlView.Controls.Add(this.label19);
			this.pnlView.Controls.Add(this.label9);
			this.pnlView.Controls.Add(this.label15);
			this.pnlView.Controls.Add(this.label8);
			this.pnlView.Location = new System.Drawing.Point(619, 12);
			this.pnlView.Name = "pnlView";
			this.pnlView.Size = new System.Drawing.Size(242, 332);
			this.pnlView.TabIndex = 16;
			// 
			// lblSens
			// 
			this.lblSens.AutoSize = true;
			this.lblSens.Location = new System.Drawing.Point(7, 271);
			this.lblSens.Name = "lblSens";
			this.lblSens.Size = new System.Drawing.Size(53, 12);
			this.lblSens.TabIndex = 34;
			this.lblSens.Text = "--------";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(131, 258);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 12);
			this.label24.TabIndex = 33;
			this.label24.Text = "RecvNum:";
			// 
			// lblRecvNum
			// 
			this.lblRecvNum.AutoSize = true;
			this.lblRecvNum.Location = new System.Drawing.Point(187, 257);
			this.lblRecvNum.Name = "lblRecvNum";
			this.lblRecvNum.Size = new System.Drawing.Size(11, 12);
			this.lblRecvNum.TabIndex = 33;
			this.lblRecvNum.Text = "0";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(7, 243);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 16);
			this.checkBox1.TabIndex = 32;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// btnMotorAllCopy
			// 
			this.btnMotorAllCopy.Location = new System.Drawing.Point(7, 216);
			this.btnMotorAllCopy.Name = "btnMotorAllCopy";
			this.btnMotorAllCopy.Size = new System.Drawing.Size(159, 23);
			this.btnMotorAllCopy.TabIndex = 31;
			this.btnMotorAllCopy.Text = "←　全モータ出力を左へコピー";
			this.btnMotorAllCopy.UseVisualStyleBackColor = true;
			this.btnMotorAllCopy.Click += new System.EventHandler(this.btnMotorAllCopy_Click);
			// 
			// txtViewPower
			// 
			this.txtViewPower.Location = new System.Drawing.Point(126, 89);
			this.txtViewPower.Name = "txtViewPower";
			this.txtViewPower.Size = new System.Drawing.Size(60, 19);
			this.txtViewPower.TabIndex = 28;
			// 
			// btnTestB
			// 
			this.btnTestB.Location = new System.Drawing.Point(154, 296);
			this.btnTestB.Name = "btnTestB";
			this.btnTestB.Size = new System.Drawing.Size(74, 26);
			this.btnTestB.TabIndex = 27;
			this.btnTestB.Text = "Trace_Start";
			this.btnTestB.UseVisualStyleBackColor = true;
			this.btnTestB.Click += new System.EventHandler(this.btnTestB_Click);
			// 
			// txtViewRR
			// 
			this.txtViewRR.Location = new System.Drawing.Point(106, 191);
			this.txtViewRR.Name = "txtViewRR";
			this.txtViewRR.Size = new System.Drawing.Size(60, 19);
			this.txtViewRR.TabIndex = 2;
			this.txtViewRR.Text = "-30";
			// 
			// btnTestA
			// 
			this.btnTestA.Location = new System.Drawing.Point(8, 296);
			this.btnTestA.Name = "btnTestA";
			this.btnTestA.Size = new System.Drawing.Size(74, 26);
			this.btnTestA.TabIndex = 27;
			this.btnTestA.Text = "a-30,90;";
			this.btnTestA.UseVisualStyleBackColor = true;
			this.btnTestA.Click += new System.EventHandler(this.btnTestA_Click);
			// 
			// txtViewRL
			// 
			this.txtViewRL.Location = new System.Drawing.Point(14, 191);
			this.txtViewRL.Name = "txtViewRL";
			this.txtViewRL.Size = new System.Drawing.Size(60, 19);
			this.txtViewRL.TabIndex = 2;
			this.txtViewRL.Text = "-30";
			// 
			// txtViewFR
			// 
			this.txtViewFR.Location = new System.Drawing.Point(106, 153);
			this.txtViewFR.Name = "txtViewFR";
			this.txtViewFR.Size = new System.Drawing.Size(60, 19);
			this.txtViewFR.TabIndex = 2;
			this.txtViewFR.Text = "-30";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(104, 176);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(83, 12);
			this.label13.TabIndex = 0;
			this.label13.Text = "モータ出力FL[%]";
			// 
			// txtViewFL
			// 
			this.txtViewFL.Location = new System.Drawing.Point(14, 153);
			this.txtViewFL.Name = "txtViewFL";
			this.txtViewFL.Size = new System.Drawing.Size(60, 19);
			this.txtViewFL.TabIndex = 2;
			this.txtViewFL.Text = "-30";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 12);
			this.label12.TabIndex = 0;
			this.label12.Text = "モータ出力FL[%]";
			// 
			// txtViewAngle
			// 
			this.txtViewAngle.Location = new System.Drawing.Point(126, 64);
			this.txtViewAngle.Name = "txtViewAngle";
			this.txtViewAngle.Size = new System.Drawing.Size(60, 19);
			this.txtViewAngle.TabIndex = 2;
			this.txtViewAngle.Text = "-30";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(104, 138);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "モータ出力FL[%]";
			// 
			// txtViewVMax
			// 
			this.txtViewVMax.Location = new System.Drawing.Point(126, 35);
			this.txtViewVMax.Name = "txtViewVMax";
			this.txtViewVMax.Size = new System.Drawing.Size(60, 19);
			this.txtViewVMax.TabIndex = 2;
			this.txtViewVMax.Text = "42";
			// 
			// txtViewV
			// 
			this.txtViewV.Location = new System.Drawing.Point(14, 35);
			this.txtViewV.Name = "txtViewV";
			this.txtViewV.Size = new System.Drawing.Size(60, 19);
			this.txtViewV.TabIndex = 2;
			this.txtViewV.Text = "42";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 138);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 12);
			this.label10.TabIndex = 0;
			this.label10.Text = "モータ出力FL[%]";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(50, 92);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(70, 12);
			this.label19.TabIndex = 0;
			this.label19.Text = "モータ出力[%]";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 67);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(109, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "現在のハンドル角[°]";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(124, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 12);
			this.label15.TabIndex = 0;
			this.label15.Text = "最高速度 x10[m/s]";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 12);
			this.label8.TabIndex = 0;
			this.label8.Text = "現在速度 x10[m/s]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 214);
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
			this.pnlSet.Controls.Add(this.nudSetFR);
			this.pnlSet.Controls.Add(this.nudSetRL);
			this.pnlSet.Controls.Add(this.nudSetFL);
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
			this.label6.Size = new System.Drawing.Size(21, 12);
			this.label6.TabIndex = 19;
			this.label6.Text = "RR";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 12);
			this.label5.TabIndex = 20;
			this.label5.Text = "RL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(123, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 12);
			this.label4.TabIndex = 21;
			this.label4.Text = "FR";
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
			this.label3.Size = new System.Drawing.Size(18, 12);
			this.label3.TabIndex = 22;
			this.label3.Text = "FL";
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
			// nudSetFR
			// 
			this.nudSetFR.Enabled = false;
			this.nudSetFR.Location = new System.Drawing.Point(82, 142);
			this.nudSetFR.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudSetFR.Name = "nudSetFR";
			this.nudSetFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.nudSetFR.Size = new System.Drawing.Size(59, 19);
			this.nudSetFR.TabIndex = 15;
			this.nudSetFR.ValueChanged += new System.EventHandler(this.nudSetAllMotor_ValueChanged);
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
			// nudSetFL
			// 
			this.nudSetFL.Enabled = false;
			this.nudSetFL.Location = new System.Drawing.Point(17, 142);
			this.nudSetFL.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudSetFL.Name = "nudSetFL";
			this.nudSetFL.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.nudSetFL.Size = new System.Drawing.Size(59, 19);
			this.nudSetFL.TabIndex = 18;
			this.nudSetFL.ValueChanged += new System.EventHandler(this.nudSetAllMotor_ValueChanged);
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
			this.pctGraph.Size = new System.Drawing.Size(1056, 131);
			this.pctGraph.TabIndex = 8;
			this.pctGraph.TabStop = false;
			// 
			// pnlGraph
			// 
			this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlGraph.Controls.Add(this.pctGraph);
			this.pnlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGraph.Location = new System.Drawing.Point(0, 354);
			this.pnlGraph.Name = "pnlGraph";
			this.pnlGraph.Size = new System.Drawing.Size(1060, 135);
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
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1060, 489);
			this.Controls.Add(this.pnlGraph);
			this.Controls.Add(this.pnlCTL);
			this.KeyPreview = true;
			this.Name = "frmMain";
			this.Text = "MCRControlMonitor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
			((System.ComponentModel.ISupportInitialize)(this.nudSetFR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetRL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSetFL)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudSetFR;
        private System.Windows.Forms.NumericUpDown nudSetRL;
        private System.Windows.Forms.NumericUpDown nudSetFL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtViewRR;
        private System.Windows.Forms.TextBox txtViewRL;
        private System.Windows.Forms.TextBox txtViewFR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtViewFL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtViewAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtViewV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudSetV;
        private System.Windows.Forms.TextBox txtViewVMax;
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
		private System.Windows.Forms.Button btnTestB;
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
		private System.Windows.Forms.Button btnMotorAllCopy;
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
		private System.Windows.Forms.Label lblSens;
		private System.Windows.Forms.ListBox lstBox;

    }
}

