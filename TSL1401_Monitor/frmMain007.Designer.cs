namespace TSL1401_Monitor
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
			this.pnlView = new System.Windows.Forms.Panel();
			this.txtGraph7 = new System.Windows.Forms.TextBox();
			this.txtGraph6 = new System.Windows.Forms.TextBox();
			this.chkG7 = new System.Windows.Forms.CheckBox();
			this.txtGraph5 = new System.Windows.Forms.TextBox();
			this.chkG6 = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.chkG5 = new System.Windows.Forms.CheckBox();
			this.label15 = new System.Windows.Forms.Label();
			this.chkG4 = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.chkG3 = new System.Windows.Forms.CheckBox();
			this.label30 = new System.Windows.Forms.Label();
			this.chkG2 = new System.Windows.Forms.CheckBox();
			this.label31 = new System.Windows.Forms.Label();
			this.lblSensGyro = new System.Windows.Forms.Label();
			this.chkG1 = new System.Windows.Forms.CheckBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.chkG0 = new System.Windows.Forms.CheckBox();
			this.txtGraph0 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtGraph1 = new System.Windows.Forms.TextBox();
			this.txtGraph2 = new System.Windows.Forms.TextBox();
			this.txtGraph3 = new System.Windows.Forms.TextBox();
			this.txtGraph4 = new System.Windows.Forms.TextBox();
			this.txtSens = new System.Windows.Forms.TextBox();
			this.txtCycleL = new System.Windows.Forms.TextBox();
			this.txtSpeedL = new System.Windows.Forms.TextBox();
			this.Cycle = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRecv = new System.Windows.Forms.TextBox();
			this.txtTerm = new System.Windows.Forms.TextBox();
			this.pnlParam = new System.Windows.Forms.Panel();
			this.nudDelayAdc = new System.Windows.Forms.NumericUpDown();
			this.nudInteg = new System.Windows.Forms.NumericUpDown();
			this.nudDelay = new System.Windows.Forms.NumericUpDown();
			this.txtMinCycle = new System.Windows.Forms.TextBox();
			this.txtMaxSpeed = new System.Windows.Forms.TextBox();
			this.txtAcrSpeed = new System.Windows.Forms.TextBox();
			this.btnSendParam = new System.Windows.Forms.Button();
			this.txtF5 = new System.Windows.Forms.TextBox();
			this.txtF4 = new System.Windows.Forms.TextBox();
			this.txtF3 = new System.Windows.Forms.TextBox();
			this.txtF2 = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtF1 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.btnTest_01 = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblRecvBufferNum2 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.nudCommandWait1 = new System.Windows.Forms.NumericUpDown();
			this.label27 = new System.Windows.Forms.Label();
			this.lblLogRecordSize = new System.Windows.Forms.Label();
			this.chkLog = new System.Windows.Forms.CheckBox();
			this.lblPortConnect = new System.Windows.Forms.Label();
			this.btnDisConnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.cmbBaudRate = new System.Windows.Forms.ComboBox();
			this.cmbPort = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.pctGraph = new System.Windows.Forms.PictureBox();
			this.pnlGraph = new System.Windows.Forms.Panel();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.timerLogView = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.pctGraph2 = new System.Windows.Forms.PictureBox();
			this.pnlGraph2 = new System.Windows.Forms.Panel();
			this.pnlCTL.SuspendLayout();
			this.pnlView.SuspendLayout();
			this.pnlParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDelayAdc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInteg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
			this.pnlControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCommandWait1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctGraph)).BeginInit();
			this.pnlGraph.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctGraph2)).BeginInit();
			this.pnlGraph2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCTL
			// 
			this.pnlCTL.Controls.Add(this.lstBox);
			this.pnlCTL.Controls.Add(this.pnlView);
			this.pnlCTL.Controls.Add(this.txtRecv);
			this.pnlCTL.Controls.Add(this.txtTerm);
			this.pnlCTL.Controls.Add(this.pnlParam);
			this.pnlCTL.Controls.Add(this.label2);
			this.pnlCTL.Controls.Add(this.label1);
			this.pnlCTL.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCTL.Location = new System.Drawing.Point(0, 0);
			this.pnlCTL.Name = "pnlCTL";
			this.pnlCTL.Size = new System.Drawing.Size(833, 356);
			this.pnlCTL.TabIndex = 5;
			// 
			// lstBox
			// 
			this.lstBox.BackColor = System.Drawing.Color.Navy;
			this.lstBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lstBox.ForeColor = System.Drawing.Color.White;
			this.lstBox.FormattingEnabled = true;
			this.lstBox.ItemHeight = 12;
			this.lstBox.Location = new System.Drawing.Point(197, 24);
			this.lstBox.Name = "lstBox";
			this.lstBox.Size = new System.Drawing.Size(164, 304);
			this.lstBox.TabIndex = 18;
			// 
			// pnlView
			// 
			this.pnlView.Controls.Add(this.txtGraph7);
			this.pnlView.Controls.Add(this.txtGraph6);
			this.pnlView.Controls.Add(this.chkG7);
			this.pnlView.Controls.Add(this.txtGraph5);
			this.pnlView.Controls.Add(this.chkG6);
			this.pnlView.Controls.Add(this.label8);
			this.pnlView.Controls.Add(this.chkG5);
			this.pnlView.Controls.Add(this.label15);
			this.pnlView.Controls.Add(this.chkG4);
			this.pnlView.Controls.Add(this.label9);
			this.pnlView.Controls.Add(this.chkG3);
			this.pnlView.Controls.Add(this.label30);
			this.pnlView.Controls.Add(this.chkG2);
			this.pnlView.Controls.Add(this.label31);
			this.pnlView.Controls.Add(this.lblSensGyro);
			this.pnlView.Controls.Add(this.chkG1);
			this.pnlView.Controls.Add(this.label35);
			this.pnlView.Controls.Add(this.label32);
			this.pnlView.Controls.Add(this.chkG0);
			this.pnlView.Controls.Add(this.txtGraph0);
			this.pnlView.Controls.Add(this.label14);
			this.pnlView.Controls.Add(this.txtGraph1);
			this.pnlView.Controls.Add(this.txtGraph2);
			this.pnlView.Controls.Add(this.txtGraph3);
			this.pnlView.Controls.Add(this.txtGraph4);
			this.pnlView.Controls.Add(this.txtSens);
			this.pnlView.Controls.Add(this.txtCycleL);
			this.pnlView.Controls.Add(this.txtSpeedL);
			this.pnlView.Controls.Add(this.Cycle);
			this.pnlView.Controls.Add(this.label6);
			this.pnlView.Location = new System.Drawing.Point(367, 3);
			this.pnlView.Name = "pnlView";
			this.pnlView.Size = new System.Drawing.Size(195, 323);
			this.pnlView.TabIndex = 36;
			// 
			// txtGraph7
			// 
			this.txtGraph7.Location = new System.Drawing.Point(113, 181);
			this.txtGraph7.Name = "txtGraph7";
			this.txtGraph7.Size = new System.Drawing.Size(45, 19);
			this.txtGraph7.TabIndex = 11;
			this.txtGraph7.Text = "0";
			this.txtGraph7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtGraph6
			// 
			this.txtGraph6.Location = new System.Drawing.Point(113, 156);
			this.txtGraph6.Name = "txtGraph6";
			this.txtGraph6.Size = new System.Drawing.Size(45, 19);
			this.txtGraph6.TabIndex = 11;
			this.txtGraph6.Text = "0";
			this.txtGraph6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkG7
			// 
			this.chkG7.AutoSize = true;
			this.chkG7.Checked = true;
			this.chkG7.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG7.Location = new System.Drawing.Point(164, 183);
			this.chkG7.Name = "chkG7";
			this.chkG7.Size = new System.Drawing.Size(30, 16);
			this.chkG7.TabIndex = 34;
			this.chkG7.Text = "7";
			this.chkG7.UseVisualStyleBackColor = true;
			this.chkG7.CheckedChanged += new System.EventHandler(this.chkG7_CheckedChanged);
			// 
			// txtGraph5
			// 
			this.txtGraph5.Location = new System.Drawing.Point(113, 131);
			this.txtGraph5.Name = "txtGraph5";
			this.txtGraph5.Size = new System.Drawing.Size(45, 19);
			this.txtGraph5.TabIndex = 11;
			this.txtGraph5.Text = "0";
			this.txtGraph5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkG6
			// 
			this.chkG6.AutoSize = true;
			this.chkG6.Checked = true;
			this.chkG6.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG6.Location = new System.Drawing.Point(164, 158);
			this.chkG6.Name = "chkG6";
			this.chkG6.Size = new System.Drawing.Size(30, 16);
			this.chkG6.TabIndex = 34;
			this.chkG6.Text = "6";
			this.chkG6.UseVisualStyleBackColor = true;
			this.chkG6.CheckedChanged += new System.EventHandler(this.chkG6_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 12);
			this.label8.TabIndex = 0;
			this.label8.Text = "Camera_Center";
			// 
			// chkG5
			// 
			this.chkG5.AutoSize = true;
			this.chkG5.Checked = true;
			this.chkG5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG5.Location = new System.Drawing.Point(164, 133);
			this.chkG5.Name = "chkG5";
			this.chkG5.Size = new System.Drawing.Size(30, 16);
			this.chkG5.TabIndex = 34;
			this.chkG5.Text = "5";
			this.chkG5.UseVisualStyleBackColor = true;
			this.chkG5.CheckedChanged += new System.EventHandler(this.chkG5_CheckedChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 34);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(109, 12);
			this.label15.TabIndex = 0;
			this.label15.Text = "Camera_CenterIndex";
			// 
			// chkG4
			// 
			this.chkG4.AutoSize = true;
			this.chkG4.Checked = true;
			this.chkG4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG4.Location = new System.Drawing.Point(164, 108);
			this.chkG4.Name = "chkG4";
			this.chkG4.Size = new System.Drawing.Size(30, 16);
			this.chkG4.TabIndex = 34;
			this.chkG4.Text = "4";
			this.chkG4.UseVisualStyleBackColor = true;
			this.chkG4.CheckedChanged += new System.EventHandler(this.chkG4_CheckedChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 59);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "Camera_MinIndex";
			// 
			// chkG3
			// 
			this.chkG3.AutoSize = true;
			this.chkG3.Checked = true;
			this.chkG3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG3.Location = new System.Drawing.Point(164, 83);
			this.chkG3.Name = "chkG3";
			this.chkG3.Size = new System.Drawing.Size(30, 16);
			this.chkG3.TabIndex = 34;
			this.chkG3.Text = "3";
			this.chkG3.UseVisualStyleBackColor = true;
			this.chkG3.CheckedChanged += new System.EventHandler(this.chkG3_CheckedChanged);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(3, 84);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(96, 12);
			this.label30.TabIndex = 0;
			this.label30.Text = "Camera_MaxIndex";
			// 
			// chkG2
			// 
			this.chkG2.AutoSize = true;
			this.chkG2.Checked = true;
			this.chkG2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG2.Location = new System.Drawing.Point(164, 58);
			this.chkG2.Name = "chkG2";
			this.chkG2.Size = new System.Drawing.Size(30, 16);
			this.chkG2.TabIndex = 34;
			this.chkG2.Text = "2";
			this.chkG2.UseVisualStyleBackColor = true;
			this.chkG2.CheckedChanged += new System.EventHandler(this.chkG2_CheckedChanged);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(3, 109);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(91, 12);
			this.label31.TabIndex = 0;
			this.label31.Text = "制御入力-1 tau1";
			// 
			// lblSensGyro
			// 
			this.lblSensGyro.AutoSize = true;
			this.lblSensGyro.Location = new System.Drawing.Point(3, 184);
			this.lblSensGyro.Name = "lblSensGyro";
			this.lblSensGyro.Size = new System.Drawing.Size(94, 12);
			this.lblSensGyro.TabIndex = 0;
			this.lblSensGyro.Text = "ジャイロセンサ生値";
			// 
			// chkG1
			// 
			this.chkG1.AutoSize = true;
			this.chkG1.Checked = true;
			this.chkG1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG1.Location = new System.Drawing.Point(164, 33);
			this.chkG1.Name = "chkG1";
			this.chkG1.Size = new System.Drawing.Size(30, 16);
			this.chkG1.TabIndex = 34;
			this.chkG1.Text = "1";
			this.chkG1.UseVisualStyleBackColor = true;
			this.chkG1.CheckedChanged += new System.EventHandler(this.chkG1_CheckedChanged);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(3, 159);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(94, 12);
			this.label35.TabIndex = 0;
			this.label35.Text = "モータ速度[mm/s]";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(3, 134);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(73, 12);
			this.label32.TabIndex = 0;
			this.label32.Text = "制御入力 tau";
			// 
			// chkG0
			// 
			this.chkG0.AutoSize = true;
			this.chkG0.Checked = true;
			this.chkG0.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkG0.Location = new System.Drawing.Point(164, 8);
			this.chkG0.Name = "chkG0";
			this.chkG0.Size = new System.Drawing.Size(30, 16);
			this.chkG0.TabIndex = 34;
			this.chkG0.Text = "0";
			this.chkG0.UseVisualStyleBackColor = true;
			this.chkG0.CheckedChanged += new System.EventHandler(this.chkG0_CheckedChanged);
			// 
			// txtGraph0
			// 
			this.txtGraph0.Location = new System.Drawing.Point(113, 6);
			this.txtGraph0.Name = "txtGraph0";
			this.txtGraph0.Size = new System.Drawing.Size(45, 19);
			this.txtGraph0.TabIndex = 6;
			this.txtGraph0.Text = "0";
			this.txtGraph0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(3, 243);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 12);
			this.label14.TabIndex = 0;
			this.label14.Text = "sens";
			// 
			// txtGraph1
			// 
			this.txtGraph1.Location = new System.Drawing.Point(113, 31);
			this.txtGraph1.Name = "txtGraph1";
			this.txtGraph1.Size = new System.Drawing.Size(45, 19);
			this.txtGraph1.TabIndex = 7;
			this.txtGraph1.Text = "0";
			this.txtGraph1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtGraph2
			// 
			this.txtGraph2.Location = new System.Drawing.Point(113, 56);
			this.txtGraph2.Name = "txtGraph2";
			this.txtGraph2.Size = new System.Drawing.Size(45, 19);
			this.txtGraph2.TabIndex = 8;
			this.txtGraph2.Text = "0";
			this.txtGraph2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtGraph3
			// 
			this.txtGraph3.Location = new System.Drawing.Point(113, 81);
			this.txtGraph3.Name = "txtGraph3";
			this.txtGraph3.Size = new System.Drawing.Size(45, 19);
			this.txtGraph3.TabIndex = 9;
			this.txtGraph3.Text = "0";
			this.txtGraph3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtGraph4
			// 
			this.txtGraph4.Location = new System.Drawing.Point(113, 106);
			this.txtGraph4.Name = "txtGraph4";
			this.txtGraph4.Size = new System.Drawing.Size(45, 19);
			this.txtGraph4.TabIndex = 10;
			this.txtGraph4.Text = "0";
			this.txtGraph4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtSens
			// 
			this.txtSens.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtSens.Location = new System.Drawing.Point(50, 240);
			this.txtSens.Name = "txtSens";
			this.txtSens.Size = new System.Drawing.Size(60, 19);
			this.txtSens.TabIndex = 12;
			this.txtSens.Text = "11111111";
			this.txtSens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCycleL
			// 
			this.txtCycleL.Location = new System.Drawing.Point(50, 290);
			this.txtCycleL.Name = "txtCycleL";
			this.txtCycleL.Size = new System.Drawing.Size(60, 19);
			this.txtCycleL.TabIndex = 14;
			this.txtCycleL.Text = "0";
			// 
			// txtSpeedL
			// 
			this.txtSpeedL.Location = new System.Drawing.Point(50, 265);
			this.txtSpeedL.Name = "txtSpeedL";
			this.txtSpeedL.Size = new System.Drawing.Size(60, 19);
			this.txtSpeedL.TabIndex = 14;
			this.txtSpeedL.Text = "0";
			// 
			// Cycle
			// 
			this.Cycle.AutoSize = true;
			this.Cycle.Location = new System.Drawing.Point(3, 293);
			this.Cycle.Name = "Cycle";
			this.Cycle.Size = new System.Drawing.Size(34, 12);
			this.Cycle.TabIndex = 0;
			this.Cycle.Text = "Cycle";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 268);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "Speed";
			// 
			// txtRecv
			// 
			this.txtRecv.BackColor = System.Drawing.Color.Navy;
			this.txtRecv.ForeColor = System.Drawing.Color.White;
			this.txtRecv.Location = new System.Drawing.Point(3, 335);
			this.txtRecv.Name = "txtRecv";
			this.txtRecv.Size = new System.Drawing.Size(558, 19);
			this.txtRecv.TabIndex = 4;
			// 
			// txtTerm
			// 
			this.txtTerm.BackColor = System.Drawing.Color.Navy;
			this.txtTerm.ForeColor = System.Drawing.Color.White;
			this.txtTerm.Location = new System.Drawing.Point(5, 24);
			this.txtTerm.Multiline = true;
			this.txtTerm.Name = "txtTerm";
			this.txtTerm.Size = new System.Drawing.Size(186, 304);
			this.txtTerm.TabIndex = 3;
			this.txtTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerm_KeyPress);
			// 
			// pnlParam
			// 
			this.pnlParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlParam.Controls.Add(this.nudDelayAdc);
			this.pnlParam.Controls.Add(this.nudInteg);
			this.pnlParam.Controls.Add(this.nudDelay);
			this.pnlParam.Controls.Add(this.txtMinCycle);
			this.pnlParam.Controls.Add(this.txtMaxSpeed);
			this.pnlParam.Controls.Add(this.txtAcrSpeed);
			this.pnlParam.Controls.Add(this.btnSendParam);
			this.pnlParam.Controls.Add(this.txtF5);
			this.pnlParam.Controls.Add(this.txtF4);
			this.pnlParam.Controls.Add(this.txtF3);
			this.pnlParam.Controls.Add(this.txtF2);
			this.pnlParam.Controls.Add(this.label39);
			this.pnlParam.Controls.Add(this.label38);
			this.pnlParam.Controls.Add(this.label36);
			this.pnlParam.Controls.Add(this.label33);
			this.pnlParam.Controls.Add(this.label28);
			this.pnlParam.Controls.Add(this.label26);
			this.pnlParam.Controls.Add(this.label29);
			this.pnlParam.Controls.Add(this.label13);
			this.pnlParam.Controls.Add(this.txtF1);
			this.pnlParam.Controls.Add(this.label12);
			this.pnlParam.Controls.Add(this.label11);
			this.pnlParam.Controls.Add(this.label10);
			this.pnlParam.Location = new System.Drawing.Point(568, 3);
			this.pnlParam.Name = "pnlParam";
			this.pnlParam.Size = new System.Drawing.Size(242, 214);
			this.pnlParam.TabIndex = 16;
			// 
			// nudDelayAdc
			// 
			this.nudDelayAdc.Location = new System.Drawing.Point(186, 51);
			this.nudDelayAdc.Name = "nudDelayAdc";
			this.nudDelayAdc.Size = new System.Drawing.Size(51, 19);
			this.nudDelayAdc.TabIndex = 38;
			this.nudDelayAdc.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.nudDelayAdc.ValueChanged += new System.EventHandler(this.nudDelayAdc_ValueChanged);
			// 
			// nudInteg
			// 
			this.nudInteg.Location = new System.Drawing.Point(186, 4);
			this.nudInteg.Name = "nudInteg";
			this.nudInteg.Size = new System.Drawing.Size(51, 19);
			this.nudInteg.TabIndex = 37;
			this.nudInteg.ValueChanged += new System.EventHandler(this.nudInteg_ValueChanged);
			// 
			// nudDelay
			// 
			this.nudDelay.Location = new System.Drawing.Point(186, 27);
			this.nudDelay.Name = "nudDelay";
			this.nudDelay.Size = new System.Drawing.Size(51, 19);
			this.nudDelay.TabIndex = 37;
			this.nudDelay.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.nudDelay.ValueChanged += new System.EventHandler(this.nudDelay_ValueChanged);
			// 
			// txtMinCycle
			// 
			this.txtMinCycle.Location = new System.Drawing.Point(73, 184);
			this.txtMinCycle.Name = "txtMinCycle";
			this.txtMinCycle.Size = new System.Drawing.Size(54, 19);
			this.txtMinCycle.TabIndex = 36;
			this.txtMinCycle.Text = "2";
			// 
			// txtMaxSpeed
			// 
			this.txtMaxSpeed.Location = new System.Drawing.Point(73, 159);
			this.txtMaxSpeed.Name = "txtMaxSpeed";
			this.txtMaxSpeed.Size = new System.Drawing.Size(54, 19);
			this.txtMaxSpeed.TabIndex = 36;
			this.txtMaxSpeed.Text = "360";
			// 
			// txtAcrSpeed
			// 
			this.txtAcrSpeed.Location = new System.Drawing.Point(73, 134);
			this.txtAcrSpeed.Name = "txtAcrSpeed";
			this.txtAcrSpeed.Size = new System.Drawing.Size(54, 19);
			this.txtAcrSpeed.TabIndex = 35;
			this.txtAcrSpeed.Text = "0";
			// 
			// btnSendParam
			// 
			this.btnSendParam.Location = new System.Drawing.Point(142, 159);
			this.btnSendParam.Name = "btnSendParam";
			this.btnSendParam.Size = new System.Drawing.Size(95, 44);
			this.btnSendParam.TabIndex = 27;
			this.btnSendParam.Text = "パラメータ送信";
			this.btnSendParam.UseVisualStyleBackColor = true;
			this.btnSendParam.Click += new System.EventHandler(this.btnSendCommand_Click);
			// 
			// txtF5
			// 
			this.txtF5.Location = new System.Drawing.Point(27, 103);
			this.txtF5.Name = "txtF5";
			this.txtF5.Size = new System.Drawing.Size(76, 19);
			this.txtF5.TabIndex = 5;
			this.txtF5.Text = "-0.1636";
			// 
			// txtF4
			// 
			this.txtF4.Location = new System.Drawing.Point(27, 78);
			this.txtF4.Name = "txtF4";
			this.txtF4.Size = new System.Drawing.Size(76, 19);
			this.txtF4.TabIndex = 4;
			this.txtF4.Text = "-800E-5";
			// 
			// txtF3
			// 
			this.txtF3.Location = new System.Drawing.Point(27, 53);
			this.txtF3.Name = "txtF3";
			this.txtF3.Size = new System.Drawing.Size(76, 19);
			this.txtF3.TabIndex = 3;
			this.txtF3.Text = "0.00726";
			// 
			// txtF2
			// 
			this.txtF2.Location = new System.Drawing.Point(27, 28);
			this.txtF2.Name = "txtF2";
			this.txtF2.Size = new System.Drawing.Size(76, 19);
			this.txtF2.TabIndex = 2;
			this.txtF2.Text = "500";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(7, 187);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(58, 12);
			this.label39.TabIndex = 0;
			this.label39.Text = "最小Cycle";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(7, 162);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(60, 12);
			this.label38.TabIndex = 0;
			this.label38.Text = "最大Speed";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(9, 137);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(53, 12);
			this.label36.TabIndex = 0;
			this.label36.Text = "目標速度";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(126, 53);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(54, 12);
			this.label33.TabIndex = 0;
			this.label33.Text = "delay_adc";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(121, 5);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(59, 12);
			this.label28.TabIndex = 0;
			this.label28.Text = "integration";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(117, 29);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(63, 12);
			this.label26.TabIndex = 0;
			this.label26.Text = "delay_pulse";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(3, 106);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(18, 12);
			this.label29.TabIndex = 0;
			this.label29.Text = "F5";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 81);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(18, 12);
			this.label13.TabIndex = 0;
			this.label13.Text = "F4";
			// 
			// txtF1
			// 
			this.txtF1.Location = new System.Drawing.Point(27, 3);
			this.txtF1.Name = "txtF1";
			this.txtF1.Size = new System.Drawing.Size(76, 19);
			this.txtF1.TabIndex = 1;
			this.txtF1.Text = "500";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(18, 12);
			this.label12.TabIndex = 0;
			this.label12.Text = "F3";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 31);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(18, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "F2";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 12);
			this.label10.TabIndex = 0;
			this.label10.Text = "F1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(195, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Receive Text";
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
			// pnlControl
			// 
			this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlControl.Controls.Add(this.label5);
			this.pnlControl.Controls.Add(this.btnTest_01);
			this.pnlControl.Controls.Add(this.btnReset);
			this.pnlControl.Controls.Add(this.lblRecvBufferNum2);
			this.pnlControl.Controls.Add(this.label25);
			this.pnlControl.Controls.Add(this.nudCommandWait1);
			this.pnlControl.Controls.Add(this.label27);
			this.pnlControl.Controls.Add(this.lblLogRecordSize);
			this.pnlControl.Controls.Add(this.chkLog);
			this.pnlControl.Controls.Add(this.lblPortConnect);
			this.pnlControl.Controls.Add(this.btnDisConnect);
			this.pnlControl.Controls.Add(this.btnConnect);
			this.pnlControl.Controls.Add(this.cmbBaudRate);
			this.pnlControl.Controls.Add(this.cmbPort);
			this.pnlControl.Controls.Add(this.label17);
			this.pnlControl.Controls.Add(this.label16);
			this.pnlControl.Location = new System.Drawing.Point(524, 360);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(300, 252);
			this.pnlControl.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 12);
			this.label5.TabIndex = 34;
			this.label5.Text = "ログレコードサイズ問い合わせ";
			// 
			// btnTest_01
			// 
			this.btnTest_01.Location = new System.Drawing.Point(150, 202);
			this.btnTest_01.Name = "btnTest_01";
			this.btnTest_01.Size = new System.Drawing.Size(32, 20);
			this.btnTest_01.TabIndex = 33;
			this.btnTest_01.Text = "+";
			this.btnTest_01.UseVisualStyleBackColor = true;
			this.btnTest_01.Click += new System.EventHandler(this.btnTest_01_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(9, 105);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(56, 25);
			this.btnReset.TabIndex = 31;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblRecvBufferNum2
			// 
			this.lblRecvBufferNum2.AutoSize = true;
			this.lblRecvBufferNum2.Location = new System.Drawing.Point(92, 176);
			this.lblRecvBufferNum2.Name = "lblRecvBufferNum2";
			this.lblRecvBufferNum2.Size = new System.Drawing.Size(11, 12);
			this.lblRecvBufferNum2.TabIndex = 30;
			this.lblRecvBufferNum2.Text = "0";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(5, 176);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(84, 12);
			this.label25.TabIndex = 30;
			this.label25.Text = "BytesToRead =";
			// 
			// nudCommandWait1
			// 
			this.nudCommandWait1.Location = new System.Drawing.Point(94, 221);
			this.nudCommandWait1.Name = "nudCommandWait1";
			this.nudCommandWait1.Size = new System.Drawing.Size(56, 19);
			this.nudCommandWait1.TabIndex = 29;
			this.nudCommandWait1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(5, 224);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(83, 12);
			this.label27.TabIndex = 26;
			this.label27.Text = "CommandWait1";
			// 
			// lblLogRecordSize
			// 
			this.lblLogRecordSize.AutoSize = true;
			this.lblLogRecordSize.Location = new System.Drawing.Point(5, 162);
			this.lblLogRecordSize.Name = "lblLogRecordSize";
			this.lblLogRecordSize.Size = new System.Drawing.Size(92, 12);
			this.lblLogRecordSize.TabIndex = 26;
			this.lblLogRecordSize.Text = "Logのバイト数 = 0";
			// 
			// chkLog
			// 
			this.chkLog.AutoSize = true;
			this.chkLog.Location = new System.Drawing.Point(15, 71);
			this.chkLog.Name = "chkLog";
			this.chkLog.Size = new System.Drawing.Size(66, 16);
			this.chkLog.TabIndex = 5;
			this.chkLog.Text = "Log出力";
			this.chkLog.UseVisualStyleBackColor = true;
			this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
			// 
			// lblPortConnect
			// 
			this.lblPortConnect.AutoSize = true;
			this.lblPortConnect.Location = new System.Drawing.Point(238, 22);
			this.lblPortConnect.Name = "lblPortConnect";
			this.lblPortConnect.Size = new System.Drawing.Size(47, 12);
			this.lblPortConnect.TabIndex = 4;
			this.lblPortConnect.Text = "・・・切断";
			// 
			// btnDisConnect
			// 
			this.btnDisConnect.Location = new System.Drawing.Point(163, 59);
			this.btnDisConnect.Name = "btnDisConnect";
			this.btnDisConnect.Size = new System.Drawing.Size(75, 39);
			this.btnDisConnect.TabIndex = 3;
			this.btnDisConnect.Text = "切断";
			this.btnDisConnect.UseVisualStyleBackColor = true;
			this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(163, 3);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 50);
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
			this.cmbBaudRate.Location = new System.Drawing.Point(88, 29);
			this.cmbBaudRate.Name = "cmbBaudRate";
			this.cmbBaudRate.Size = new System.Drawing.Size(67, 20);
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
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
			this.cmbPort.Location = new System.Drawing.Point(88, 3);
			this.cmbPort.Name = "cmbPort";
			this.cmbPort.Size = new System.Drawing.Size(67, 20);
			this.cmbPort.TabIndex = 1;
			this.cmbPort.Text = "COM6";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(30, 32);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(52, 12);
			this.label17.TabIndex = 0;
			this.label17.Text = "ボーレート";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(13, 6);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(69, 12);
			this.label16.TabIndex = 0;
			this.label16.Text = "シリアルポート";
			// 
			// pctGraph
			// 
			this.pctGraph.BackColor = System.Drawing.Color.Navy;
			this.pctGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pctGraph.Location = new System.Drawing.Point(0, 0);
			this.pctGraph.Margin = new System.Windows.Forms.Padding(30);
			this.pctGraph.Name = "pctGraph";
			this.pctGraph.Size = new System.Drawing.Size(256, 256);
			this.pctGraph.TabIndex = 8;
			this.pctGraph.TabStop = false;
			// 
			// pnlGraph
			// 
			this.pnlGraph.BackColor = System.Drawing.Color.Navy;
			this.pnlGraph.Controls.Add(this.pctGraph);
			this.pnlGraph.Location = new System.Drawing.Point(0, 356);
			this.pnlGraph.Name = "pnlGraph";
			this.pnlGraph.Size = new System.Drawing.Size(256, 256);
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
			this.timerLogView.Interval = 20;
			this.timerLogView.Tick += new System.EventHandler(this.timerLogView_Tick);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			// 
			// pctGraph2
			// 
			this.pctGraph2.Location = new System.Drawing.Point(0, 0);
			this.pctGraph2.Name = "pctGraph2";
			this.pctGraph2.Size = new System.Drawing.Size(256, 256);
			this.pctGraph2.TabIndex = 10;
			this.pctGraph2.TabStop = false;
			// 
			// pnlGraph2
			// 
			this.pnlGraph2.BackColor = System.Drawing.Color.Navy;
			this.pnlGraph2.Controls.Add(this.pctGraph2);
			this.pnlGraph2.Location = new System.Drawing.Point(262, 356);
			this.pnlGraph2.Name = "pnlGraph2";
			this.pnlGraph2.Size = new System.Drawing.Size(256, 256);
			this.pnlGraph2.TabIndex = 11;
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnSendParam;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 622);
			this.Controls.Add(this.pnlCTL);
			this.Controls.Add(this.pnlGraph2);
			this.Controls.Add(this.pnlGraph);
			this.Controls.Add(this.pnlControl);
			this.Name = "frmMain";
			this.Text = "TSL1401_Monitor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.pnlCTL.ResumeLayout(false);
			this.pnlCTL.PerformLayout();
			this.pnlView.ResumeLayout(false);
			this.pnlView.PerformLayout();
			this.pnlParam.ResumeLayout(false);
			this.pnlParam.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDelayAdc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInteg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCommandWait1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctGraph)).EndInit();
			this.pnlGraph.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctGraph2)).EndInit();
			this.pnlGraph2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel pnlCTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.TextBox txtTerm;
		private System.Windows.Forms.Panel pnlParam;
        private System.Windows.Forms.TextBox txtF4;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGraph2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGraph0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGraph1;
		private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pctGraph;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblPortConnect;
		private System.Windows.Forms.Button btnSendParam;
		private System.Windows.Forms.Timer timerLogView;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.ListBox lstBox;
		private System.Windows.Forms.TextBox txtSens;
		private System.Windows.Forms.TextBox txtF5;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox txtGraph5;
		private System.Windows.Forms.TextBox txtGraph4;
		private System.Windows.Forms.TextBox txtGraph3;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Button btnTest_01;
		private System.Windows.Forms.CheckBox chkG6;
		private System.Windows.Forms.CheckBox chkG5;
		private System.Windows.Forms.CheckBox chkG4;
		private System.Windows.Forms.CheckBox chkG3;
		private System.Windows.Forms.CheckBox chkG2;
		private System.Windows.Forms.CheckBox chkG1;
		private System.Windows.Forms.CheckBox chkG0;
		private System.Windows.Forms.CheckBox chkLog;
		private System.Windows.Forms.Label lblLogRecordSize;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSpeedL;
		private System.Windows.Forms.Label lblRecvBufferNum2;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.NumericUpDown nudCommandWait1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtGraph6;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.TextBox txtAcrSpeed;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label Cycle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaxSpeed;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.TextBox txtMinCycle;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.TextBox txtGraph7;
		private System.Windows.Forms.CheckBox chkG7;
		private System.Windows.Forms.Label lblSensGyro;
		private System.Windows.Forms.PictureBox pctGraph2;
		private System.Windows.Forms.Panel pnlGraph2;
		private System.Windows.Forms.TextBox txtCycleL;
		private System.Windows.Forms.NumericUpDown nudInteg;
		private System.Windows.Forms.NumericUpDown nudDelay;
		private System.Windows.Forms.NumericUpDown nudDelayAdc;

    }
}

