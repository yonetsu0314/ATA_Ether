namespace AtaTest {
    partial class FormAtaTest {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtaTest));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxConfigFile = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GblA = new System.Windows.Forms.TabPage();
            this.textBoxSDE = new System.Windows.Forms.TextBox();
            this.textBoxD2MWDC = new System.Windows.Forms.TextBox();
            this.textBoxTGTF = new System.Windows.Forms.TextBox();
            this.textBoxD2MWATSD = new System.Windows.Forms.TextBox();
            this.textBoxDCACycle = new System.Windows.Forms.TextBox();
            this.textBoxADSTT = new System.Windows.Forms.TextBox();
            this.textBoxSDM = new System.Windows.Forms.TextBox();
            this.textBoxSDDC = new System.Windows.Forms.TextBox();
            this.textBoxSDDB = new System.Windows.Forms.TextBox();
            this.textBoxADE = new System.Windows.Forms.TextBox();
            this.textBoxOWF = new System.Windows.Forms.TextBox();
            this.textBoxSDFC = new System.Windows.Forms.TextBox();
            this.textBoxAWF = new System.Windows.Forms.TextBox();
            this.textBoxSDLT = new System.Windows.Forms.TextBox();
            this.textBoxPP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GblB = new System.Windows.Forms.TabPage();
            this.textBoxCWB = new System.Windows.Forms.TextBox();
            this.textBoxDEFT = new System.Windows.Forms.TextBox();
            this.textBoxBIASW = new System.Windows.Forms.TextBox();
            this.textBoxATAT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Stale = new System.Windows.Forms.TabPage();
            this.textBoxSTC = new System.Windows.Forms.TextBox();
            this.textBoxSTTMM = new System.Windows.Forms.TextBox();
            this.textBoxSDW = new System.Windows.Forms.TextBox();
            this.textBoxSTTHH = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Mess = new System.Windows.Forms.TabPage();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.UnsolicitedCMD = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_R8 = new System.Windows.Forms.Label();
            this.label_R7 = new System.Windows.Forms.Label();
            this.label_R6 = new System.Windows.Forms.Label();
            this.label_R5 = new System.Windows.Forms.Label();
            this.label_R4 = new System.Windows.Forms.Label();
            this.label_R3 = new System.Windows.Forms.Label();
            this.label_R2 = new System.Windows.Forms.Label();
            this.label_R1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBoxAutoOut = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox_R_oneshot = new System.Windows.Forms.TextBox();
            this.textBox_R_interval = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxUnsolicited = new System.Windows.Forms.TextBox();
            this.Last50 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoKeyRset = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoRequest = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonLast75 = new System.Windows.Forms.RadioButton();
            this.radioButtonLast50 = new System.Windows.Forms.RadioButton();
            this.buttonLast50Req = new System.Windows.Forms.Button();
            this.buttonSampleKeyReset = new System.Windows.Forms.Button();
            this.textBoxLast50 = new System.Windows.Forms.TextBox();
            this.buttonReq = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.radioButtonC1 = new System.Windows.Forms.RadioButton();
            this.radioButtonC2 = new System.Windows.Forms.RadioButton();
            this.groupBox_ChSelect = new System.Windows.Forms.GroupBox();
            this.textBoxDEST = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnEtherStop = new System.Windows.Forms.Button();
            this.btnEtherStart = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxEtherPort = new System.Windows.Forms.TextBox();
            this.textBoxEtherAdrs = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GblA.SuspendLayout();
            this.GblB.SuspendLayout();
            this.Stale.SuspendLayout();
            this.Mess.SuspendLayout();
            this.UnsolicitedCMD.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Last50.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_ChSelect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 542);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "Config File";
            // 
            // textBoxConfigFile
            // 
            this.textBoxConfigFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConfigFile.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxConfigFile.Location = new System.Drawing.Point(96, 540);
            this.textBoxConfigFile.Name = "textBoxConfigFile";
            this.textBoxConfigFile.ReadOnly = true;
            this.textBoxConfigFile.Size = new System.Drawing.Size(497, 18);
            this.textBoxConfigFile.TabIndex = 26;
            this.textBoxConfigFile.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helphToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.SaveAsToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.fileToolStripMenuItem.Text = "パラメータ(&P)";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.OpenFileToolStripMenuItem.Text = "ファイルを開く(&O)";
            // 
            // SaveAsToolStripMenuItem1
            // 
            this.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1";
            this.SaveAsToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.SaveAsToolStripMenuItem1.Text = "名前を付けて保存(&A)";
            this.SaveAsToolStripMenuItem1.Click += new System.EventHandler(this.SaveAsToolStripMenuItem1_Click);
            // 
            // helphToolStripMenuItem
            // 
            this.helphToolStripMenuItem.Name = "helphToolStripMenuItem";
            this.helphToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helphToolStripMenuItem.Text = "ヘルプ(&H)";
            this.helphToolStripMenuItem.Click += new System.EventHandler(this.helphToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Location = new System.Drawing.Point(27, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 66);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(78, 26);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(60, 25);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 25);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(60, 26);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.lblStopBits);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.cmbStopBits);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.label6);
            this.gbPortSettings.Location = new System.Drawing.Point(183, 34);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(398, 66);
            this.gbPortSettings.TabIndex = 31;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "Serial Port Settings";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(12, 18);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(57, 12);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
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
            this.cmbPortName.Location = new System.Drawing.Point(13, 33);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 20);
            this.cmbPortName.TabIndex = 2;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(301, 18);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(55, 12);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits:";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cmbBaudRate.Location = new System.Drawing.Point(86, 32);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(69, 20);
            this.cmbBaudRate.TabIndex = 3;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(302, 33);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(87, 20);
            this.cmbStopBits.TabIndex = 6;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(85, 18);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(61, 12);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(229, 18);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(56, 12);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "Data Bits:";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(161, 32);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(60, 20);
            this.cmbParity.TabIndex = 4;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(230, 33);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(60, 20);
            this.cmbDataBits.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Parity:";
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.BackColor = System.Drawing.Color.LightGray;
            this.textBoxReceive.ForeColor = System.Drawing.Color.Black;
            this.textBoxReceive.Location = new System.Drawing.Point(27, 433);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceive.Size = new System.Drawing.Size(554, 101);
            this.textBoxReceive.TabIndex = 30;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GblA);
            this.tabControl1.Controls.Add(this.GblB);
            this.tabControl1.Controls.Add(this.Stale);
            this.tabControl1.Controls.Add(this.Mess);
            this.tabControl1.Controls.Add(this.UnsolicitedCMD);
            this.tabControl1.Controls.Add(this.Last50);
            this.tabControl1.Location = new System.Drawing.Point(27, 233);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 194);
            this.tabControl1.TabIndex = 32;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // GblA
            // 
            this.GblA.Controls.Add(this.textBoxSDE);
            this.GblA.Controls.Add(this.textBoxD2MWDC);
            this.GblA.Controls.Add(this.textBoxTGTF);
            this.GblA.Controls.Add(this.textBoxD2MWATSD);
            this.GblA.Controls.Add(this.textBoxDCACycle);
            this.GblA.Controls.Add(this.textBoxADSTT);
            this.GblA.Controls.Add(this.textBoxSDM);
            this.GblA.Controls.Add(this.textBoxSDDC);
            this.GblA.Controls.Add(this.textBoxSDDB);
            this.GblA.Controls.Add(this.textBoxADE);
            this.GblA.Controls.Add(this.textBoxOWF);
            this.GblA.Controls.Add(this.textBoxSDFC);
            this.GblA.Controls.Add(this.textBoxAWF);
            this.GblA.Controls.Add(this.textBoxSDLT);
            this.GblA.Controls.Add(this.textBoxPP);
            this.GblA.Controls.Add(this.label17);
            this.GblA.Controls.Add(this.label15);
            this.GblA.Controls.Add(this.label14);
            this.GblA.Controls.Add(this.label13);
            this.GblA.Controls.Add(this.label12);
            this.GblA.Controls.Add(this.label11);
            this.GblA.Controls.Add(this.label10);
            this.GblA.Controls.Add(this.label9);
            this.GblA.Controls.Add(this.label8);
            this.GblA.Controls.Add(this.label7);
            this.GblA.Controls.Add(this.label5);
            this.GblA.Controls.Add(this.label4);
            this.GblA.Controls.Add(this.label3);
            this.GblA.Controls.Add(this.label2);
            this.GblA.Controls.Add(this.label1);
            this.GblA.Location = new System.Drawing.Point(4, 22);
            this.GblA.Name = "GblA";
            this.GblA.Padding = new System.Windows.Forms.Padding(3);
            this.GblA.Size = new System.Drawing.Size(546, 168);
            this.GblA.TabIndex = 0;
            this.GblA.Text = "Global A";
            this.GblA.UseVisualStyleBackColor = true;
            // 
            // textBoxSDE
            // 
            this.textBoxSDE.Location = new System.Drawing.Point(159, 144);
            this.textBoxSDE.Name = "textBoxSDE";
            this.textBoxSDE.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDE.TabIndex = 1;
            this.textBoxSDE.Tag = "";
            // 
            // textBoxD2MWDC
            // 
            this.textBoxD2MWDC.Location = new System.Drawing.Point(393, 125);
            this.textBoxD2MWDC.Name = "textBoxD2MWDC";
            this.textBoxD2MWDC.Size = new System.Drawing.Size(100, 19);
            this.textBoxD2MWDC.TabIndex = 1;
            this.textBoxD2MWDC.Tag = "";
            // 
            // textBoxTGTF
            // 
            this.textBoxTGTF.Location = new System.Drawing.Point(159, 125);
            this.textBoxTGTF.Name = "textBoxTGTF";
            this.textBoxTGTF.Size = new System.Drawing.Size(100, 19);
            this.textBoxTGTF.TabIndex = 1;
            this.textBoxTGTF.Tag = "";
            // 
            // textBoxD2MWATSD
            // 
            this.textBoxD2MWATSD.Location = new System.Drawing.Point(393, 68);
            this.textBoxD2MWATSD.Name = "textBoxD2MWATSD";
            this.textBoxD2MWATSD.Size = new System.Drawing.Size(100, 19);
            this.textBoxD2MWATSD.TabIndex = 1;
            this.textBoxD2MWATSD.Tag = "";
            // 
            // textBoxDCACycle
            // 
            this.textBoxDCACycle.Location = new System.Drawing.Point(159, 68);
            this.textBoxDCACycle.Name = "textBoxDCACycle";
            this.textBoxDCACycle.Size = new System.Drawing.Size(100, 19);
            this.textBoxDCACycle.TabIndex = 1;
            this.textBoxDCACycle.Tag = "";
            // 
            // textBoxADSTT
            // 
            this.textBoxADSTT.Location = new System.Drawing.Point(393, 106);
            this.textBoxADSTT.Name = "textBoxADSTT";
            this.textBoxADSTT.Size = new System.Drawing.Size(100, 19);
            this.textBoxADSTT.TabIndex = 1;
            this.textBoxADSTT.Tag = "";
            // 
            // textBoxSDM
            // 
            this.textBoxSDM.Location = new System.Drawing.Point(159, 106);
            this.textBoxSDM.Name = "textBoxSDM";
            this.textBoxSDM.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDM.TabIndex = 1;
            this.textBoxSDM.Tag = "";
            // 
            // textBoxSDDC
            // 
            this.textBoxSDDC.Location = new System.Drawing.Point(393, 49);
            this.textBoxSDDC.Name = "textBoxSDDC";
            this.textBoxSDDC.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDDC.TabIndex = 1;
            this.textBoxSDDC.Tag = "";
            // 
            // textBoxSDDB
            // 
            this.textBoxSDDB.Location = new System.Drawing.Point(159, 49);
            this.textBoxSDDB.Name = "textBoxSDDB";
            this.textBoxSDDB.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDDB.TabIndex = 1;
            this.textBoxSDDB.Tag = "";
            // 
            // textBoxADE
            // 
            this.textBoxADE.Location = new System.Drawing.Point(393, 87);
            this.textBoxADE.Name = "textBoxADE";
            this.textBoxADE.Size = new System.Drawing.Size(100, 19);
            this.textBoxADE.TabIndex = 1;
            this.textBoxADE.Tag = "";
            // 
            // textBoxOWF
            // 
            this.textBoxOWF.Location = new System.Drawing.Point(159, 87);
            this.textBoxOWF.Name = "textBoxOWF";
            this.textBoxOWF.Size = new System.Drawing.Size(100, 19);
            this.textBoxOWF.TabIndex = 1;
            this.textBoxOWF.Tag = "";
            // 
            // textBoxSDFC
            // 
            this.textBoxSDFC.Location = new System.Drawing.Point(393, 30);
            this.textBoxSDFC.Name = "textBoxSDFC";
            this.textBoxSDFC.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDFC.TabIndex = 1;
            this.textBoxSDFC.Tag = "";
            // 
            // textBoxAWF
            // 
            this.textBoxAWF.Location = new System.Drawing.Point(159, 30);
            this.textBoxAWF.Name = "textBoxAWF";
            this.textBoxAWF.Size = new System.Drawing.Size(100, 19);
            this.textBoxAWF.TabIndex = 1;
            this.textBoxAWF.Tag = "";
            // 
            // textBoxSDLT
            // 
            this.textBoxSDLT.Location = new System.Drawing.Point(393, 11);
            this.textBoxSDLT.Name = "textBoxSDLT";
            this.textBoxSDLT.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDLT.TabIndex = 1;
            this.textBoxSDLT.Tag = "";
            // 
            // textBoxPP
            // 
            this.textBoxPP.Location = new System.Drawing.Point(159, 11);
            this.textBoxPP.Name = "textBoxPP";
            this.textBoxPP.Size = new System.Drawing.Size(100, 19);
            this.textBoxPP.TabIndex = 1;
            this.textBoxPP.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(300, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "D2MWDryCycle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "ADStartTime";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "ADEnable";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "D2MWAutoSD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "SDDryCycle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "SDFeedClear";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "SDLockTime";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "SDEnable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "TgtF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "DCA SDM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "DCA OWF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "DCA Cycle Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stagger Delay Dead band";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ATA AWF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATA P%";
            // 
            // GblB
            // 
            this.GblB.Controls.Add(this.textBoxCWB);
            this.GblB.Controls.Add(this.textBoxDEFT);
            this.GblB.Controls.Add(this.textBoxBIASW);
            this.GblB.Controls.Add(this.textBoxATAT);
            this.GblB.Controls.Add(this.label18);
            this.GblB.Controls.Add(this.label19);
            this.GblB.Controls.Add(this.label20);
            this.GblB.Controls.Add(this.label22);
            this.GblB.Location = new System.Drawing.Point(4, 22);
            this.GblB.Name = "GblB";
            this.GblB.Padding = new System.Windows.Forms.Padding(3);
            this.GblB.Size = new System.Drawing.Size(546, 168);
            this.GblB.TabIndex = 1;
            this.GblB.Text = "Global B";
            this.GblB.UseVisualStyleBackColor = true;
            // 
            // textBoxCWB
            // 
            this.textBoxCWB.Location = new System.Drawing.Point(167, 76);
            this.textBoxCWB.Name = "textBoxCWB";
            this.textBoxCWB.Size = new System.Drawing.Size(100, 19);
            this.textBoxCWB.TabIndex = 7;
            this.textBoxCWB.Tag = "";
            // 
            // textBoxDEFT
            // 
            this.textBoxDEFT.Location = new System.Drawing.Point(167, 57);
            this.textBoxDEFT.Name = "textBoxDEFT";
            this.textBoxDEFT.Size = new System.Drawing.Size(100, 19);
            this.textBoxDEFT.TabIndex = 9;
            this.textBoxDEFT.Tag = "";
            // 
            // textBoxBIASW
            // 
            this.textBoxBIASW.Location = new System.Drawing.Point(167, 95);
            this.textBoxBIASW.Name = "textBoxBIASW";
            this.textBoxBIASW.Size = new System.Drawing.Size(100, 19);
            this.textBoxBIASW.TabIndex = 8;
            this.textBoxBIASW.Tag = "";
            // 
            // textBoxATAT
            // 
            this.textBoxATAT.Location = new System.Drawing.Point(167, 37);
            this.textBoxATAT.Name = "textBoxATAT";
            this.textBoxATAT.Size = new System.Drawing.Size(100, 19);
            this.textBoxATAT.TabIndex = 10;
            this.textBoxATAT.Tag = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(66, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "ATA Bias Weight";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 12);
            this.label19.TabIndex = 3;
            this.label19.Text = "CWB";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "ATA Default Time";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(98, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 12);
            this.label22.TabIndex = 5;
            this.label22.Text = "ATA Timer";
            // 
            // Stale
            // 
            this.Stale.Controls.Add(this.textBoxSTC);
            this.Stale.Controls.Add(this.textBoxSTTMM);
            this.Stale.Controls.Add(this.textBoxSDW);
            this.Stale.Controls.Add(this.textBoxSTTHH);
            this.Stale.Controls.Add(this.label21);
            this.Stale.Controls.Add(this.label23);
            this.Stale.Controls.Add(this.label24);
            this.Stale.Controls.Add(this.label25);
            this.Stale.Location = new System.Drawing.Point(4, 22);
            this.Stale.Name = "Stale";
            this.Stale.Size = new System.Drawing.Size(546, 168);
            this.Stale.TabIndex = 2;
            this.Stale.Text = "Stale Lockout";
            this.Stale.UseVisualStyleBackColor = true;
            // 
            // textBoxSTC
            // 
            this.textBoxSTC.Location = new System.Drawing.Point(210, 80);
            this.textBoxSTC.Name = "textBoxSTC";
            this.textBoxSTC.Size = new System.Drawing.Size(100, 19);
            this.textBoxSTC.TabIndex = 15;
            this.textBoxSTC.Tag = "";
            // 
            // textBoxSTTMM
            // 
            this.textBoxSTTMM.Location = new System.Drawing.Point(210, 61);
            this.textBoxSTTMM.Name = "textBoxSTTMM";
            this.textBoxSTTMM.Size = new System.Drawing.Size(100, 19);
            this.textBoxSTTMM.TabIndex = 17;
            this.textBoxSTTMM.Tag = "";
            // 
            // textBoxSDW
            // 
            this.textBoxSDW.Location = new System.Drawing.Point(210, 99);
            this.textBoxSDW.Name = "textBoxSDW";
            this.textBoxSDW.Size = new System.Drawing.Size(100, 19);
            this.textBoxSDW.TabIndex = 16;
            this.textBoxSDW.Tag = "";
            // 
            // textBoxSTTHH
            // 
            this.textBoxSTTHH.Location = new System.Drawing.Point(210, 41);
            this.textBoxSTTHH.Name = "textBoxSTTHH";
            this.textBoxSTTHH.Size = new System.Drawing.Size(100, 19);
            this.textBoxSTTHH.TabIndex = 18;
            this.textBoxSTTHH.Tag = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(102, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 12);
            this.label21.TabIndex = 13;
            this.label21.Text = "Stale Dump Weight";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(94, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 12);
            this.label23.TabIndex = 12;
            this.label23.Text = "Stale Timeout Count";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(53, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 12);
            this.label24.TabIndex = 11;
            this.label24.Text = "Stale Timeout Time [Minute]";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(63, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 12);
            this.label25.TabIndex = 14;
            this.label25.Text = "Stale Timeout Time [Hour]";
            // 
            // Mess
            // 
            this.Mess.Controls.Add(this.textBoxMessage);
            this.Mess.Controls.Add(this.label27);
            this.Mess.Location = new System.Drawing.Point(4, 22);
            this.Mess.Name = "Mess";
            this.Mess.Size = new System.Drawing.Size(546, 168);
            this.Mess.TabIndex = 3;
            this.Mess.Text = "Message";
            this.Mess.UseVisualStyleBackColor = true;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMessage.Location = new System.Drawing.Point(152, 38);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(210, 23);
            this.textBoxMessage.TabIndex = 20;
            this.textBoxMessage.Tag = "";
            this.textBoxMessage.Text = "1234567890123456789012345";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(50, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 12);
            this.label27.TabIndex = 19;
            this.label27.Text = "Message [25char]";
            // 
            // UnsolicitedCMD
            // 
            this.UnsolicitedCMD.Controls.Add(this.label28);
            this.UnsolicitedCMD.Controls.Add(this.groupBox6);
            this.UnsolicitedCMD.Controls.Add(this.groupBox5);
            this.UnsolicitedCMD.Controls.Add(this.textBoxUnsolicited);
            this.UnsolicitedCMD.Location = new System.Drawing.Point(4, 22);
            this.UnsolicitedCMD.Name = "UnsolicitedCMD";
            this.UnsolicitedCMD.Size = new System.Drawing.Size(546, 168);
            this.UnsolicitedCMD.TabIndex = 4;
            this.UnsolicitedCMD.Text = "Unsolicited Cmd";
            this.UnsolicitedCMD.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label28.Location = new System.Drawing.Point(114, 107);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 12);
            this.label28.TabIndex = 35;
            this.label28.Text = "Relay Unit Control";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label_R8);
            this.groupBox6.Controls.Add(this.label_R7);
            this.groupBox6.Controls.Add(this.label_R6);
            this.groupBox6.Controls.Add(this.label_R5);
            this.groupBox6.Controls.Add(this.label_R4);
            this.groupBox6.Controls.Add(this.label_R3);
            this.groupBox6.Controls.Add(this.label_R2);
            this.groupBox6.Controls.Add(this.label_R1);
            this.groupBox6.Location = new System.Drawing.Point(9, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 42);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input";
            // 
            // label_R8
            // 
            this.label_R8.AutoSize = true;
            this.label_R8.BackColor = System.Drawing.Color.LightGray;
            this.label_R8.Location = new System.Drawing.Point(197, 20);
            this.label_R8.Name = "label_R8";
            this.label_R8.Size = new System.Drawing.Size(22, 12);
            this.label_R8.TabIndex = 33;
            this.label_R8.Text = "IN8";
            // 
            // label_R7
            // 
            this.label_R7.AutoSize = true;
            this.label_R7.BackColor = System.Drawing.Color.LightGray;
            this.label_R7.Location = new System.Drawing.Point(172, 20);
            this.label_R7.Name = "label_R7";
            this.label_R7.Size = new System.Drawing.Size(22, 12);
            this.label_R7.TabIndex = 33;
            this.label_R7.Text = "IN7";
            // 
            // label_R6
            // 
            this.label_R6.AutoSize = true;
            this.label_R6.BackColor = System.Drawing.Color.LightGray;
            this.label_R6.Location = new System.Drawing.Point(144, 20);
            this.label_R6.Name = "label_R6";
            this.label_R6.Size = new System.Drawing.Size(22, 12);
            this.label_R6.TabIndex = 33;
            this.label_R6.Text = "IN6";
            // 
            // label_R5
            // 
            this.label_R5.AutoSize = true;
            this.label_R5.BackColor = System.Drawing.Color.LightGray;
            this.label_R5.Location = new System.Drawing.Point(117, 20);
            this.label_R5.Name = "label_R5";
            this.label_R5.Size = new System.Drawing.Size(22, 12);
            this.label_R5.TabIndex = 33;
            this.label_R5.Text = "IN5";
            // 
            // label_R4
            // 
            this.label_R4.AutoSize = true;
            this.label_R4.BackColor = System.Drawing.Color.LightGray;
            this.label_R4.Location = new System.Drawing.Point(89, 20);
            this.label_R4.Name = "label_R4";
            this.label_R4.Size = new System.Drawing.Size(22, 12);
            this.label_R4.TabIndex = 33;
            this.label_R4.Text = "IN4";
            // 
            // label_R3
            // 
            this.label_R3.AutoSize = true;
            this.label_R3.BackColor = System.Drawing.Color.LightGray;
            this.label_R3.Location = new System.Drawing.Point(61, 19);
            this.label_R3.Name = "label_R3";
            this.label_R3.Size = new System.Drawing.Size(22, 12);
            this.label_R3.TabIndex = 33;
            this.label_R3.Text = "IN3";
            // 
            // label_R2
            // 
            this.label_R2.AutoSize = true;
            this.label_R2.BackColor = System.Drawing.Color.LightGray;
            this.label_R2.Location = new System.Drawing.Point(33, 20);
            this.label_R2.Name = "label_R2";
            this.label_R2.Size = new System.Drawing.Size(22, 12);
            this.label_R2.TabIndex = 33;
            this.label_R2.Text = "IN2";
            // 
            // label_R1
            // 
            this.label_R1.AutoSize = true;
            this.label_R1.BackColor = System.Drawing.Color.LightGray;
            this.label_R1.Location = new System.Drawing.Point(5, 20);
            this.label_R1.Name = "label_R1";
            this.label_R1.Size = new System.Drawing.Size(22, 12);
            this.label_R1.TabIndex = 33;
            this.label_R1.Text = "IN1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.checkBoxAutoOut);
            this.groupBox5.Controls.Add(this.checkBox8);
            this.groupBox5.Controls.Add(this.textBox_R_oneshot);
            this.groupBox5.Controls.Add(this.textBox_R_interval);
            this.groupBox5.Controls.Add(this.checkBox7);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(238, 107);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 56);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OutPut";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(234, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "Ival.";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(236, 34);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "Out";
            // 
            // checkBoxAutoOut
            // 
            this.checkBoxAutoOut.AutoSize = true;
            this.checkBoxAutoOut.Location = new System.Drawing.Point(185, 21);
            this.checkBoxAutoOut.Name = "checkBoxAutoOut";
            this.checkBoxAutoOut.Size = new System.Drawing.Size(48, 16);
            this.checkBoxAutoOut.TabIndex = 31;
            this.checkBoxAutoOut.Text = "Auto";
            this.checkBoxAutoOut.UseVisualStyleBackColor = true;
            this.checkBoxAutoOut.CheckedChanged += new System.EventHandler(this.checkBoxAutoOut_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(125, 37);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(38, 16);
            this.checkBox8.TabIndex = 31;
            this.checkBox8.Text = "R8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox_R_oneshot
            // 
            this.textBox_R_oneshot.Location = new System.Drawing.Point(262, 31);
            this.textBox_R_oneshot.Name = "textBox_R_oneshot";
            this.textBox_R_oneshot.Size = new System.Drawing.Size(35, 19);
            this.textBox_R_oneshot.TabIndex = 1;
            this.textBox_R_oneshot.Tag = "";
            this.textBox_R_oneshot.Text = "100";
            // 
            // textBox_R_interval
            // 
            this.textBox_R_interval.Location = new System.Drawing.Point(262, 13);
            this.textBox_R_interval.Name = "textBox_R_interval";
            this.textBox_R_interval.Size = new System.Drawing.Size(35, 19);
            this.textBox_R_interval.TabIndex = 1;
            this.textBox_R_interval.Tag = "";
            this.textBox_R_interval.Text = "500";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(87, 37);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(38, 16);
            this.checkBox7.TabIndex = 31;
            this.checkBox7.Text = "R7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(124, 15);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 16);
            this.checkBox4.TabIndex = 31;
            this.checkBox4.Text = "R4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(49, 37);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(38, 16);
            this.checkBox6.TabIndex = 31;
            this.checkBox6.Text = "R6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(87, 15);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(38, 16);
            this.checkBox3.TabIndex = 31;
            this.checkBox3.Text = "R3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(11, 37);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(38, 16);
            this.checkBox5.TabIndex = 31;
            this.checkBox5.Text = "R5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(48, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 16);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "R2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 16);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "R1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxUnsolicited
            // 
            this.textBoxUnsolicited.BackColor = System.Drawing.Color.White;
            this.textBoxUnsolicited.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxUnsolicited.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnsolicited.Location = new System.Drawing.Point(0, 0);
            this.textBoxUnsolicited.Multiline = true;
            this.textBoxUnsolicited.Name = "textBoxUnsolicited";
            this.textBoxUnsolicited.ReadOnly = true;
            this.textBoxUnsolicited.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUnsolicited.Size = new System.Drawing.Size(546, 104);
            this.textBoxUnsolicited.TabIndex = 30;
            this.textBoxUnsolicited.Tag = "ADD";
            // 
            // Last50
            // 
            this.Last50.Controls.Add(this.groupBox4);
            this.Last50.Controls.Add(this.groupBox3);
            this.Last50.Controls.Add(this.buttonLast50Req);
            this.Last50.Controls.Add(this.buttonSampleKeyReset);
            this.Last50.Controls.Add(this.textBoxLast50);
            this.Last50.Location = new System.Drawing.Point(4, 22);
            this.Last50.Name = "Last50";
            this.Last50.Size = new System.Drawing.Size(546, 168);
            this.Last50.TabIndex = 5;
            this.Last50.Text = "Last 50/75";
            this.Last50.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxAutoKeyRset);
            this.groupBox4.Controls.Add(this.checkBoxAutoRequest);
            this.groupBox4.Location = new System.Drawing.Point(232, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 35);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auto";
            // 
            // checkBoxAutoKeyRset
            // 
            this.checkBoxAutoKeyRset.AutoSize = true;
            this.checkBoxAutoKeyRset.Checked = true;
            this.checkBoxAutoKeyRset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoKeyRset.Location = new System.Drawing.Point(88, 14);
            this.checkBoxAutoKeyRset.Name = "checkBoxAutoKeyRset";
            this.checkBoxAutoKeyRset.Size = new System.Drawing.Size(77, 16);
            this.checkBoxAutoKeyRset.TabIndex = 1;
            this.checkBoxAutoKeyRset.Text = "Key Reset";
            this.checkBoxAutoKeyRset.UseVisualStyleBackColor = true;
            this.checkBoxAutoKeyRset.CheckedChanged += new System.EventHandler(this.checkBoxAutoKeyRset_CheckedChanged);
            // 
            // checkBoxAutoRequest
            // 
            this.checkBoxAutoRequest.AutoSize = true;
            this.checkBoxAutoRequest.Checked = true;
            this.checkBoxAutoRequest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRequest.Location = new System.Drawing.Point(7, 14);
            this.checkBoxAutoRequest.Name = "checkBoxAutoRequest";
            this.checkBoxAutoRequest.Size = new System.Drawing.Size(76, 16);
            this.checkBoxAutoRequest.TabIndex = 0;
            this.checkBoxAutoRequest.Text = "Last50/75";
            this.checkBoxAutoRequest.UseVisualStyleBackColor = true;
            this.checkBoxAutoRequest.CheckedChanged += new System.EventHandler(this.checkBoxAutoRequest_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonLast75);
            this.groupBox3.Controls.Add(this.radioButtonLast50);
            this.groupBox3.Location = new System.Drawing.Point(404, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 35);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Command";
            // 
            // radioButtonLast75
            // 
            this.radioButtonLast75.AutoSize = true;
            this.radioButtonLast75.Location = new System.Drawing.Point(73, 15);
            this.radioButtonLast75.Name = "radioButtonLast75";
            this.radioButtonLast75.Size = new System.Drawing.Size(57, 16);
            this.radioButtonLast75.TabIndex = 33;
            this.radioButtonLast75.Text = "Last75";
            this.radioButtonLast75.UseVisualStyleBackColor = true;
            // 
            // radioButtonLast50
            // 
            this.radioButtonLast50.AutoSize = true;
            this.radioButtonLast50.Checked = true;
            this.radioButtonLast50.Location = new System.Drawing.Point(12, 15);
            this.radioButtonLast50.Name = "radioButtonLast50";
            this.radioButtonLast50.Size = new System.Drawing.Size(57, 16);
            this.radioButtonLast50.TabIndex = 33;
            this.radioButtonLast50.TabStop = true;
            this.radioButtonLast50.Text = "Last50";
            this.radioButtonLast50.UseVisualStyleBackColor = true;
            // 
            // buttonLast50Req
            // 
            this.buttonLast50Req.Enabled = false;
            this.buttonLast50Req.Location = new System.Drawing.Point(8, 130);
            this.buttonLast50Req.Name = "buttonLast50Req";
            this.buttonLast50Req.Size = new System.Drawing.Size(97, 39);
            this.buttonLast50Req.TabIndex = 32;
            this.buttonLast50Req.Text = "Last 50/75 Request";
            this.buttonLast50Req.UseVisualStyleBackColor = true;
            this.buttonLast50Req.Click += new System.EventHandler(this.buttonLast50Req_Click);
            // 
            // buttonSampleKeyReset
            // 
            this.buttonSampleKeyReset.Enabled = false;
            this.buttonSampleKeyReset.Location = new System.Drawing.Point(113, 130);
            this.buttonSampleKeyReset.Name = "buttonSampleKeyReset";
            this.buttonSampleKeyReset.Size = new System.Drawing.Size(97, 39);
            this.buttonSampleKeyReset.TabIndex = 32;
            this.buttonSampleKeyReset.Text = "Sample Collect Key Reset";
            this.buttonSampleKeyReset.UseVisualStyleBackColor = true;
            this.buttonSampleKeyReset.Click += new System.EventHandler(this.buttonSampleKeyReset_Click);
            // 
            // textBoxLast50
            // 
            this.textBoxLast50.BackColor = System.Drawing.Color.White;
            this.textBoxLast50.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLast50.ForeColor = System.Drawing.Color.Black;
            this.textBoxLast50.Location = new System.Drawing.Point(0, 0);
            this.textBoxLast50.Multiline = true;
            this.textBoxLast50.Name = "textBoxLast50";
            this.textBoxLast50.ReadOnly = true;
            this.textBoxLast50.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLast50.Size = new System.Drawing.Size(546, 124);
            this.textBoxLast50.TabIndex = 31;
            this.textBoxLast50.Tag = "ADD";
            // 
            // buttonReq
            // 
            this.buttonReq.Location = new System.Drawing.Point(39, 197);
            this.buttonReq.Name = "buttonReq";
            this.buttonReq.Size = new System.Drawing.Size(60, 26);
            this.buttonReq.TabIndex = 0;
            this.buttonReq.Text = "Request";
            this.buttonReq.UseVisualStyleBackColor = true;
            this.buttonReq.Click += new System.EventHandler(this.buttonReq_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(105, 198);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(60, 25);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // radioButtonC1
            // 
            this.radioButtonC1.AutoSize = true;
            this.radioButtonC1.Checked = true;
            this.radioButtonC1.Location = new System.Drawing.Point(15, 18);
            this.radioButtonC1.Name = "radioButtonC1";
            this.radioButtonC1.Size = new System.Drawing.Size(37, 16);
            this.radioButtonC1.TabIndex = 33;
            this.radioButtonC1.TabStop = true;
            this.radioButtonC1.Text = "C1";
            this.radioButtonC1.UseVisualStyleBackColor = true;
            // 
            // radioButtonC2
            // 
            this.radioButtonC2.AutoSize = true;
            this.radioButtonC2.Location = new System.Drawing.Point(58, 18);
            this.radioButtonC2.Name = "radioButtonC2";
            this.radioButtonC2.Size = new System.Drawing.Size(37, 16);
            this.radioButtonC2.TabIndex = 33;
            this.radioButtonC2.Text = "C2";
            this.radioButtonC2.UseVisualStyleBackColor = true;
            // 
            // groupBox_ChSelect
            // 
            this.groupBox_ChSelect.Controls.Add(this.radioButtonC2);
            this.groupBox_ChSelect.Controls.Add(this.radioButtonC1);
            this.groupBox_ChSelect.Location = new System.Drawing.Point(183, 189);
            this.groupBox_ChSelect.Name = "groupBox_ChSelect";
            this.groupBox_ChSelect.Size = new System.Drawing.Size(107, 42);
            this.groupBox_ChSelect.TabIndex = 34;
            this.groupBox_ChSelect.TabStop = false;
            this.groupBox_ChSelect.Text = "Channel";
            // 
            // textBoxDEST
            // 
            this.textBoxDEST.Location = new System.Drawing.Point(333, 208);
            this.textBoxDEST.Name = "textBoxDEST";
            this.textBoxDEST.Size = new System.Drawing.Size(31, 19);
            this.textBoxDEST.TabIndex = 1;
            this.textBoxDEST.Tag = "";
            this.textBoxDEST.Text = "1";
            this.textBoxDEST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(300, 211);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "Adrs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.BtnEtherStop);
            this.groupBox2.Controls.Add(this.btnEtherStart);
            this.groupBox2.Location = new System.Drawing.Point(27, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 66);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EtherNet";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(126, 25);
            this.progressBar1.TabIndex = 35;
            this.progressBar1.Visible = false;
            // 
            // BtnEtherStop
            // 
            this.BtnEtherStop.Location = new System.Drawing.Point(78, 26);
            this.BtnEtherStop.Name = "BtnEtherStop";
            this.BtnEtherStop.Size = new System.Drawing.Size(60, 25);
            this.BtnEtherStop.TabIndex = 1;
            this.BtnEtherStop.Text = "Stop";
            this.BtnEtherStop.UseVisualStyleBackColor = true;
            this.BtnEtherStop.Click += new System.EventHandler(this.BtnEtherStop_Click);
            // 
            // btnEtherStart
            // 
            this.btnEtherStart.Location = new System.Drawing.Point(12, 25);
            this.btnEtherStart.Name = "btnEtherStart";
            this.btnEtherStart.Size = new System.Drawing.Size(60, 26);
            this.btnEtherStart.TabIndex = 0;
            this.btnEtherStart.Text = "Start";
            this.btnEtherStart.UseVisualStyleBackColor = true;
            this.btnEtherStart.Click += new System.EventHandler(this.BtnEtherStart_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.textBoxEtherPort);
            this.groupBox7.Controls.Add(this.textBoxEtherAdrs);
            this.groupBox7.Location = new System.Drawing.Point(183, 106);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(164, 66);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "EtherNet Settings";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "Adrs:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "Port:";
            // 
            // textBoxEtherPort
            // 
            this.textBoxEtherPort.Location = new System.Drawing.Point(47, 39);
            this.textBoxEtherPort.Name = "textBoxEtherPort";
            this.textBoxEtherPort.Size = new System.Drawing.Size(100, 19);
            this.textBoxEtherPort.TabIndex = 1;
            this.textBoxEtherPort.Tag = "";
            this.textBoxEtherPort.Text = "2000";
            // 
            // textBoxEtherAdrs
            // 
            this.textBoxEtherAdrs.Location = new System.Drawing.Point(47, 18);
            this.textBoxEtherAdrs.Name = "textBoxEtherAdrs";
            this.textBoxEtherAdrs.Size = new System.Drawing.Size(100, 19);
            this.textBoxEtherAdrs.TabIndex = 1;
            this.textBoxEtherAdrs.Tag = "";
            this.textBoxEtherAdrs.Text = "192.168.0.71";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormAtaTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 586);
            this.Controls.Add(this.groupBox_ChSelect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonReq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.textBoxReceive);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxConfigFile);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxDEST);
            this.Controls.Add(this.label26);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAtaTest";
            this.Text = "ATA Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AtaTest_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GblA.ResumeLayout(false);
            this.GblA.PerformLayout();
            this.GblB.ResumeLayout(false);
            this.GblB.PerformLayout();
            this.Stale.ResumeLayout(false);
            this.Stale.PerformLayout();
            this.Mess.ResumeLayout(false);
            this.Mess.PerformLayout();
            this.UnsolicitedCMD.ResumeLayout(false);
            this.UnsolicitedCMD.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Last50.ResumeLayout(false);
            this.Last50.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_ChSelect.ResumeLayout(false);
            this.groupBox_ChSelect.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxConfigFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GblA;
        private System.Windows.Forms.TabPage GblB;
        private System.Windows.Forms.Button buttonReq;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RadioButton radioButtonC1;
        private System.Windows.Forms.RadioButton radioButtonC2;
        private System.Windows.Forms.TextBox textBoxSDE;
        private System.Windows.Forms.TextBox textBoxD2MWDC;
        private System.Windows.Forms.TextBox textBoxTGTF;
        private System.Windows.Forms.TextBox textBoxD2MWATSD;
        private System.Windows.Forms.TextBox textBoxDCACycle;
        private System.Windows.Forms.TextBox textBoxADSTT;
        private System.Windows.Forms.TextBox textBoxSDM;
        private System.Windows.Forms.TextBox textBoxSDDC;
        private System.Windows.Forms.TextBox textBoxSDDB;
        private System.Windows.Forms.TextBox textBoxADE;
        private System.Windows.Forms.TextBox textBoxOWF;
        private System.Windows.Forms.TextBox textBoxSDFC;
        private System.Windows.Forms.TextBox textBoxAWF;
        private System.Windows.Forms.TextBox textBoxSDLT;
        private System.Windows.Forms.TextBox textBoxPP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_ChSelect;
        private System.Windows.Forms.TextBox textBoxCWB;
        private System.Windows.Forms.TextBox textBoxDEFT;
        private System.Windows.Forms.TextBox textBoxBIASW;
        private System.Windows.Forms.TextBox textBoxATAT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage Stale;
        private System.Windows.Forms.TextBox textBoxSTC;
        private System.Windows.Forms.TextBox textBoxSTTMM;
        private System.Windows.Forms.TextBox textBoxSDW;
        private System.Windows.Forms.TextBox textBoxSTTHH;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxDEST;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage Mess;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage UnsolicitedCMD;
        private System.Windows.Forms.TextBox textBoxUnsolicited;
        private System.Windows.Forms.TabPage Last50;
        private System.Windows.Forms.Button buttonSampleKeyReset;
        private System.Windows.Forms.TextBox textBoxLast50;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonLast75;
        private System.Windows.Forms.RadioButton radioButtonLast50;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxAutoKeyRset;
        private System.Windows.Forms.CheckBox checkBoxAutoRequest;
        private System.Windows.Forms.Button buttonLast50Req;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_R8;
        private System.Windows.Forms.Label label_R7;
        private System.Windows.Forms.Label label_R6;
        private System.Windows.Forms.Label label_R5;
        private System.Windows.Forms.Label label_R4;
        private System.Windows.Forms.Label label_R3;
        private System.Windows.Forms.Label label_R2;
        private System.Windows.Forms.Label label_R1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtherStop;
        private System.Windows.Forms.Button btnEtherStart;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxEtherAdrs;
        private System.Windows.Forms.TextBox textBoxEtherPort;
        private System.Windows.Forms.CheckBox checkBoxAutoOut;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox_R_oneshot;
        private System.Windows.Forms.TextBox textBox_R_interval;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

