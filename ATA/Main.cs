using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using MyLib;
using System.Diagnostics;
using System.Threading;

namespace AtaTest {
    public partial class FormAtaTest : Form {

        TcpClient tClient;

        delegate void SetTextCallback(string xx,string yyy);
        FormHelp  Fhelp;

        const string LAST50_REQ                 = ";";
        const string LAST75_REQ                 = "y";
        const string LASTxx_DATA                = ":";
        const string GLOBAL_A_DATA              = "n";
        const string SET_GLOBAL_A               = "n";
        const string GLOBAL_B_DATA              = "v";
        const string SET_GLOBAL_B               = "v";
        const string GLOBAL_A_REQ               = "^";
        const string GLOBAL_B_REQ               = "s";
        const string ACK                        = ">";
        const string SAMPLE_COLLECT_KEY_ON      = "A";
        const string SAMPLE_COLLECT_KEY_RESET   = "l";
        const string DISCRETE_INPUT_STATE       = "L";
        const string MACHINE_CONDITION          = "N";
        const string PRODUCT_FLOW_RATE          = "d";
        const string STALE_LOCK_REQ             = "q"; 
        const string STALE_LOCK_DATA            = "q";
        const string ROM_NO_REQ                 = ",";
        const string SET_MESS                   = "~";
        const string DISCRETE_CURRENT_STATE_REQ = "a";
        const string DISCRETE_CURRENT_STATE     = "b";
        const string DISCRETE_OUTPUT_STATE      = "M";

        public const byte STX = 0x02;
        public const byte ETX = 0x03;

        public enum data_source { 
            NONE = 0,
            DISPLAY,
            FILE
        }
        
        private RcvData Rcv = new RcvData();
        private int TcpConnected = 0;

        public FormAtaTest() {
            Console.WriteLine("Form1" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            InitializeComponent();
            InitializeControlValues();
            buttonReq.Enabled = false;
            buttonSend.Enabled = false;
            groupBox_ChSelect.Enabled = false;
        }

        private void TcpEventInit() {
            //接続OKイベント
            tClient.OnConnected += new TcpClient.ConnectedEventHandler(TClient_OnConnected);
            //接続断イベント
            tClient.OnDisconnected += new TcpClient.DisconnectedEventHandler(TClient_OnDisconnected);
            //データ受信イベント
            tClient.OnReceiveData += new TcpClient.ReceiveEventHandler(TClient_OnReceiveData);
        }
        /** 接続断イベント **/
        void TClient_OnDisconnected(object sender, EventArgs e) {
            Console.WriteLine("TClient_OnDisconnected" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            if (this.InvokeRequired)
                this.Invoke(new DisconnectedDelegate(Disconnected), new object[] { sender, e });
        }
        delegate void DisconnectedDelegate(object sender, EventArgs e);
        private void Disconnected(object sender, EventArgs e) {
            //接続断処理
            Console.WriteLine("Disconnected" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            TcpConnected = 0;
        }

        /** 接続OKイベント **/
        void TClient_OnConnected(EventArgs e) {
            //接続OK処理
            Console.WriteLine("TClient_OnConnected" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            TcpConnected = 1;
        }

        private int isTcpConnected() {
            return TcpConnected;
        }

        /** 接続ボタンを押して接続処理 **/
        private int Connect_ATA(string host, int port) {
            try {
                tClient.Connect(host, port);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            //ここで TcpConnected が１になるのを待って、ダメなら0を返す。

            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 200;
            progressBar1.Value = 1;
            progressBar1.Step = 1;

            for (int i = 0; i < progressBar1.Maximum; i++) {
                Thread.Sleep(100);
                progressBar1.PerformStep();
                if (TcpConnected == 1) break;
            }
            progressBar1.Visible = false;

            return TcpConnected;
        }

        /** データ受信イベント **/
        void TClient_OnReceiveData(byte[] b, int len) {
            Debug.WriteLine("tClient_OnReceiveData" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            //別スレッドからくるのでInvokeを使用
            if (this.InvokeRequired)
                this.Invoke(new ReceiveDelegate(ReceiveData), new object[] { b,len });
        }

        delegate void ReceiveDelegate(byte[] b, int len);

        private void ReceiveData(byte[] buf, int len) {
            Console.WriteLine("ReceiveData:" + len + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            DataReceived(buf, len);
        }
        /// <summary> Populate the form's controls with default settings. </summary>

        private void InitializeControlValues() {

            textBoxReceive.BackColor = System.Drawing.Color.LightGray; ;

            textBoxConfigFile.Enabled = false;
            textBoxConfigFile.Text = Settings.GetSettingPath();
            buttonStop.Enabled = false;
            BtnEtherStop.Enabled = false;

            Settings.LoadFromXmlFile();

            cmbParity.Items.Clear();
            cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear();
            cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity.Text = Settings.Instance.Parity.ToString();
            cmbStopBits.Text = Settings.Instance.StopBits.ToString();
            cmbDataBits.Text = Settings.Instance.DataBits.ToString();
            cmbParity.Text = Settings.Instance.Parity.ToString();
            cmbBaudRate.Text = Settings.Instance.BaudRate.ToString();

            cmbPortName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames()) {
                cmbPortName.Items.Add(s);
            }
            if (cmbPortName.Items.Contains(Settings.Instance.PortName)) {
                cmbPortName.Text = Settings.Instance.PortName;
            }
            else if (cmbPortName.Items.Count > 0) {
                cmbPortName.SelectedIndex = 0;
            }
            else {
                MessageBox.Show(this, "このPCには、COM ポートがありません。\nCOM ポートをインストール後、再起動して下さい。", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void buttonStart_Click(object sender, EventArgs e) {
            Rcv.SetCtrlCode(0x0a,0x0d);
            SerialPortStart();
            BtnEtherStop.Enabled = false;
        }
        private void BtnEtherStart_Click(object sender, EventArgs e) {
            if (tClient == null) {
                Rcv.SetCtrlCode(STX, ETX);
                tClient = new TcpClient();
                TcpEventInit();
            }
            if(Connect_ATA(textBoxEtherAdrs.Text, int.Parse(textBoxEtherPort.Text)) != 1)
                return;
             start_();
             buttonStop.Enabled = false;
        }
        private bool SerialPortStart() {
            try {
                serialPort1.BaudRate = int.Parse(cmbBaudRate.Text);
                serialPort1.DataBits = int.Parse(cmbDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                serialPort1.PortName = cmbPortName.Text;
                serialPort1.Open();
                serialPort1.RtsEnable = true;
                serialPort1.DtrEnable = true;
                start_();
                sendReqEnabled();
                return true;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void start_() {
            buttonStart.Enabled = false;
            btnEtherStart.Enabled = false;
            gbPortSettings.Enabled = false;
            buttonStop.Enabled = true;
            BtnEtherStop.Enabled = true;
            buttonReq.Enabled = true;
            buttonSend.Enabled = true;
            buttonStop.Select();
            textBoxReceive.Text = String.Empty;
            sendReqEnabled();
        }

        private void stop_() {
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            buttonReq.Enabled = false;
            buttonSend.Enabled = false;
            btnEtherStart.Enabled = true;
            BtnEtherStop.Enabled = false;
            groupBox_ChSelect.Enabled = false;
            gbPortSettings.Enabled = true;
            buttonStart.Select();
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            SerialPortStop();
        }

        private void BtnEtherStop_Click(object sender, EventArgs e) {
            if (tClient != null) {
                tClient.Close();
                tClient = null;
                stop_();
                TcpConnected = 0;
            }
        }

        private void SerialPortStop() {
            try {
                serialPort1.BreakState = false;
                serialPort1.DtrEnable = false;
                serialPort1.RtsEnable = false;
                if (serialPort1.IsOpen) {
                    serialPort1.Close();
                }
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
            }
            stop_();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            byte[] buf = new byte[512];
            int len = serialPort1.Read(buf, 0, 512);

            DataReceived(buf, len);

        }

        private void DataReceived(byte[] buf,int len) { 
            string mess,strC1C2,strDate,adrs,c1c2;
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            string s = Encoding.GetEncoding("Shift_JIS").GetString(buf, 0, len);

            Rcv.AddRcvData(buf, len);
            while (Rcv.GetCnt() > 0) {
                mess = Rcv.GetRcvData();
                setTextBox("", mess + "\r\n");  // 表示のみ

                if (tClient == null) {
                    //----- Sum check ------
                    byte[] unicodeBytes = unicode.GetBytes(mess);
                    byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
                    byte sum = 0;
                    if (asciiBytes.Length >= 3) {
                        int i;
                        for (i = 0; i < asciiBytes.Length - 2; i++) {
                            sum += asciiBytes[i];
                        }
                        byte n = (byte)((asciiBytes[i] - (byte)0x30) << 4);
                        i++;
                        n += (byte)(asciiBytes[i] - (byte)0x30);
                        if (n != sum) {
                            setTextBox("", "Sumcheck Error\r\n");
                            continue;
                        }
                    } else {
                        setTextBox("", "Text length too short\r\n");
                        continue;
                    }
                }
                //------------------------------
                strC1C2 ="C1";
                c1c2 = "0";
                if (mess.Substring(3, 1) == "1") {
                    strC1C2 = "C2";
                    c1c2 = "1";
                }
                adrs = mess.Substring(0, 1); 
                strDate = DateTime.Now.ToString();
                if (tClient == null) {
                    mess = mess.Remove(0, 2);       // Remove 13 
                } else {
                    mess = mess.Remove(0,4);       // Remove Length,port 
                }

                try {
                     switch (mess.Substring(0, 1)) {
                         case GLOBAL_A_DATA:    // Global A Response
                            setTextBox("textBoxPP", mess.Substring(2, 3));
                            setTextBox("textBoxAWF", mess.Substring(5, 2));
                            setTextBox("textBoxSDDB", mess.Substring(7, 2));
                            setTextBox("textBoxDCACycle", mess.Substring(9, 3));
                            setTextBox("textBoxOWF", mess.Substring(12, 2));
                            setTextBox("textBoxSDM", mess.Substring(14, 2));
                            setTextBox("textBoxTGTF", mess.Substring(16, 1));
                            setTextBox("textBoxSDE", mess.Substring(17, 1));
                            setTextBox("textBoxSDLT", mess.Substring(18, 2));
                            setTextBox("textBoxSDFC", mess.Substring(20, 1));
                            setTextBox("textBoxSDDC", mess.Substring(21, 2));
                            setTextBox("textBoxD2MWATSD", mess.Substring(23, 1));
                            setTextBox("textBoxADE", mess.Substring(24, 1));
                            setTextBox("textBoxADSTT", mess.Substring(25, 1));
                            setTextBox("textBoxD2MWDC", mess.Substring(26, 2));
                            break;
                         case GLOBAL_B_DATA:   // Global B Response
                            string sign = mess.Substring(12, 1);
                            setTextBox("textBoxATAT", mess.Substring(2, 3));
                            setTextBox("textBoxDEFT", mess.Substring(5, 2));
                            setTextBox("textBoxCWB", sign + mess.Substring(7, 2));
                            setTextBox("textBoxBIASW", mess.Substring(9, 3));
                            break;
                         case STALE_LOCK_DATA:    // Stale Lockout
                            setTextBox("textBoxSTTHH", mess.Substring(2, 2));
                            setTextBox("textBoxSTTMM", mess.Substring(4, 2));
                            setTextBox("textBoxSTC", mess.Substring(6, 4));
                            setTextBox("textBoxSDW", mess.Substring(10, 8));
                             break;
                         case ACK:    // Ack
                             break;
                         case SAMPLE_COLLECT_KEY_ON:    // Sample Collect State Change 
                            setTextBox("textBoxUnsolicited", strDate + " [" + strC1C2 + "] " + "Sample Collect State Change\r\n");
                            setTextBox("textBoxLast50", strDate + " [" + strC1C2 + "] " + "Sample Collect State Change\r\n");
                            string msg = "75";
                            if (checkBoxAutoRequest.Checked == true) {
                                String Cmd = LAST75_REQ;   // Lat 75 Request
                                if (radioButtonLast50.Checked == true) {
                                    Cmd = LAST50_REQ;      // lat 50 request
                                    msg = "50";
                                }
                                sendCommandEx(adrs, Cmd, c1c2, "");
                                setTextBox("textBoxLast50", strDate + " [" + strC1C2 + "] " + "Last " + msg + "Request\r\n");
                            }
                            break;
                         case SAMPLE_COLLECT_KEY_RESET:    // Sample Collect Key Reset  
                            setTextBox("textBoxUnsolicited", strDate + " [" + strC1C2 + "] " + "Sample Collect Key Reset\r\n");
                            break;
                         case DISCRETE_INPUT_STATE:    // Discrete Input State Change 
                            string on_off = "OFF";
                             bool onof = false;
                            if (mess.Substring(2, 1) == "1") {
                                on_off = "ON ";
                                onof = true;
                            }
                            string port = mess.Substring(1, 1) + "="+ on_off;
                            led(int.Parse(mess.Substring(1, 1))-1,onof);
                            setTextBox("textBoxUnsolicited", strDate + " [  ] " + "Discrete Input State Change [" + 
                                       port + "]\r\n");
                            break;
                         case DISCRETE_CURRENT_STATE:
                            if (mess.Substring(1, 1) == "I") {
                                setTextBox("textBoxUnsolicited", strDate + " [" + "  " + "] " + "Discrete Input State\r\n   ");
                                for (int i = 0; i < 8; i++) {
                                    if (mess.Substring(2 + i, 1) == "1") {
                                        led(i,true);
                                        setTextBox("textBoxUnsolicited", "IN" + (i+1).ToString() + "= ON , "); 
                                    } else {
                                        led(i,false);
                                        setTextBox("textBoxUnsolicited", "IN" + (i+1).ToString() + "= OFF , "); 
                                    }
                                }
                                setTextBox("textBoxUnsolicited", "\r\n"); 
                            }
                            break;
                         case MACHINE_CONDITION:    // Machine Condition State 
                            string strPreNo = "Pre=" + mess.Substring(4, 2);
                            double iTagt = double.Parse(mess.Substring(6, 5));
                            iTagt *= 0.1;
                            string strPwr = "Pw OFF";
                            if (mess.Substring(2, 1) == "1") {
                                strPwr = "Pw ON ";
                            }
                            string strCond = "none";
                            switch (mess.Substring(3, 1)) {
                                case "0":    strCond = "Stop";               break;
                                case "1":    strCond = "Run ";                break;
                                case "2":    strCond = "Drain";              break;
                                case "3":    strCond = "Error Stop";         break;
                                case "4":    strCond = "Zero Adjustment";    break;
                                case "5":    strCond = "Span Adjustment";    break;
                                case "6":    strCond = "Eroor Dump";         break;
                                case "7":    strCond = "Low Product";        break;
                                default:     break;
                            }
                            setTextBox("textBoxUnsolicited", strDate + " [" + strC1C2 + "] " + 
                                       "Machine Condition State [" + strPwr + "][" +
                                        strCond + "][" + strPreNo + "][" +
                                        "Tgt=" + iTagt.ToString() + "g]" + "\r\n");
                            break;
                         case PRODUCT_FLOW_RATE:    // Product Flow Rate Change 
                            double dAve = double.Parse(mess.Substring(2, 6));
                            string strAve = "[Average Flow Rate =" + dAve.ToString() + "g]";
                            setTextBox("textBoxUnsolicited", strDate + " [" + strC1C2 + "] " + "Product Flow Rate Change " + strAve + "\r\n");
                            break;
                         case LASTxx_DATA:    // Last 50/75 Combination data 
                            if (mess.Substring(2, 3) == "000") {
                                setTextBox("textBoxLast50", strDate + " [" + strC1C2 + "] " + "Last50/75 No Data\r\n");
                                if (checkBoxAutoKeyRset.Checked == true) {
                                    sendCommandEx(adrs, SAMPLE_COLLECT_KEY_RESET, c1c2, "");
                                    setTextBox("textBoxLast50", DateTime.Now.ToString() + " [" + strC1C2 + "] " + "Sample Collect Key Reset\r\n");
                                }
                            }
                            else {
                                setTextBox("textBoxLast50", strDate + " [" + strC1C2 + "] " + "Last50/75 Seq=" + mess.Substring(1, 3) + "  Weight=" + mess.Substring(20, 5) + "\r\n");
                                if (mess.Substring(1, 3) == "001" && checkBoxAutoKeyRset.Checked == true) {
                                    sendCommandEx(adrs, "l", c1c2, "");
                                    setTextBox("textBoxLast50", DateTime.Now.ToString() + " [" + strC1C2 + "] " + "Sample Collect Key Reset\r\n");
                                }
                            }
                            break;
                        default:
                            setTextBox("", "Un defined Command\r\n");
                            break;
                    }
                } catch (System.Exception ex) {
                    setTextBox("", ex.Message + "\r\n");
                    continue;
                }
            }
        }
        private void led(int no, bool on_off) {
            Color c = Color.LightGray;
            if (on_off == true) {
                c = Color.OrangeRed;
            }
            switch(no) {
                case 0: label_R1.BackColor = c; break;
                case 1: label_R2.BackColor = c; break;
                case 2: label_R3.BackColor = c; break;
                case 3: label_R4.BackColor = c; break;
                case 4: label_R5.BackColor = c; break;
                case 5: label_R6.BackColor = c; break;
                case 6: label_R7.BackColor = c; break;
                case 7: label_R8.BackColor = c; break;
            }
        }

        private void SendData(string mess) {

            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            byte[] asciiSum = new byte[2];

            // Convert the string into a byte[].
            byte[] unicodeBytes = unicode.GetBytes(mess);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
//---------------------- SUM CHECK -------------------------------
            byte[] SendData = new byte[256];
            byte sum = 0;
            int e = 1;

            if (tClient != null) {
                SendData[0] = (byte)STX;
                SendData[1] = (byte)'0';
                SendData[2] = (byte)'0';
                SendData[3] = (byte)'0';
                e = 4;
            } else {
                SendData[0] = (byte)'\n';
                e = 1;
            }

            int i;
            for (i = 0; i < asciiBytes.Length; i++) {
                SendData[i + e] = asciiBytes[i];
                sum += asciiBytes[i];
            }

            string strsum = "";
            unicode.GetString(Encoding.Convert(ascii, unicode, asciiSum));

            if (tClient != null) {
                SendData[i + e] = (byte)ETX;
            } else {
                SendData[i + e] = (byte)(((sum & 0xf0) >> 4) | 0x30);
                asciiSum[0] = SendData[i + 1];
                i++;
                SendData[i + e] = (byte)((sum & 0x0f) | 0x30);
                asciiSum[1] = SendData[i + 1];
                i++;
                SendData[i + e] = (byte)'\r';

                strsum = unicode.GetString(Encoding.Convert(ascii, unicode, asciiSum));
            }
            //---------------------- SUM CHECK -------------------------------

            setTextBox("", mess + strsum + "\r\n");     // 表示のみ

            if (tClient != null) {
                tClient.Send(SendData, asciiBytes.Length + 7);
            }
            else {
                try {
                    serialPort1.Write(SendData, 0, asciiBytes.Length + 4);
                } catch (System.Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // 送受信データの表示

        public void setTextBox(string name,string eee) {
            if (this.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(setTextBox);
                this.BeginInvoke(d, new object[] { name, eee });
            } else {
                if (name != "") {
                    CtrlLib.searchNameAndSetText(tabControl1, name, eee);
                } else {
                    textBoxReceive.AppendText(eee);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Enabled = false;
            SerialPortStop();
        }

        private void helphToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Fhelp == null) {
                Fhelp = new FormHelp();
            }
            Fhelp.StartPosition = FormStartPosition.Manual;
            Fhelp.Location = new System.Drawing.Point(this.Location.X + (this.Size.Width / 2) - (Fhelp.Size.Width / 2),
                                                        this.Location.Y + (this.Size.Height / 2) - (Fhelp.Size.Height / 2));
            Fhelp.Size = new System.Drawing.Size(287, 305);
            Fhelp.ShowDialog();
        }

        private void SaveAsToolStripMenuItem1_Click(object sender, EventArgs e) {
            System.IO.Stream stream = null;
            GetPath p = new GetPath();

            saveFileDialog1.Filter = "データ ファイル (*.dat)|*.dat|すべてのファイル (*.*)|*.*";
            saveFileDialog1.InitialDirectory = p.AppDir;
            saveFileDialog1.FileName = "AAA.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    stream = saveFileDialog1.OpenFile();
                    //ファイルに書き込む
                    Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream, sjisEnc);

                     // 書き込む
 //                   wlanObj.WrDataToFile(sw);

                    //閉じる
                    sw.Close();                 
                    stream.Close();
                }
                catch (Exception er) {
                    MessageBox.Show(er.Message);
                }
            }
        }

         //-------------------------- Program End ----------------------------
        private void AtaTest_FormClosed(object sender, FormClosedEventArgs e) {
            Settings.Instance.BaudRate = int.Parse(cmbBaudRate.Text);
            Settings.Instance.DataBits = int.Parse(cmbDataBits.Text);
            Settings.Instance.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
            Settings.Instance.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
            Settings.Instance.PortName = cmbPortName.Text;
            Settings.SaveToXmlFile();
        }

        private void buttonReq_Click(object sender, EventArgs e) {  // Request Global A
            string cmd = ",";
            string param = "";
            bool c1c2_enable = true;
            switch (tabControl1.TabPages[tabControl1.SelectedIndex].Text) {
                case "Global A":          // Global A
                    CtrlLib.ClearTextBox(tabControl1.TabPages[tabControl1.SelectedIndex]);
                    cmd = GLOBAL_A_REQ;
                    break;
                case "Global B":         // Global B
                    CtrlLib.ClearTextBox(tabControl1.TabPages[tabControl1.SelectedIndex]);
                    cmd = GLOBAL_B_REQ;
                    break;
                case "Stale Lockout":    // Stale Lockout
                    CtrlLib.ClearTextBox(tabControl1.TabPages[tabControl1.SelectedIndex]);
                    cmd = STALE_LOCK_REQ;
                    break;
                case "Unsolicited Cmd": // Unsolicited Coommand
                    cmd = DISCRETE_CURRENT_STATE_REQ;
                    param = "I";
                    c1c2_enable = false;
                    break;
                default:
                    break;
            }
             sendCommand(cmd,param,c1c2_enable);
        }

        string adrsConv() {
            byte[] b = new byte[1];

            if(tClient != null) return "";

            b[0] = (byte)(int.Parse(textBoxDEST.Text) + 0x30);
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            return sjisEnc.GetString(b);
        }

        private void buttonSend_Click(object sender, EventArgs e) {
            string c1c2 = "0";
            string cmd = ROM_NO_REQ;
            string mess = "";
            string adrs = adrsConv(); // textBoxDEST.Text;
            bool c1c2Enable = true;

            switch (tabControl1.TabPages[tabControl1.SelectedIndex].Text) {
                case "Global A":          // Global A
                    cmd = SET_GLOBAL_A;
                    mess = CtrlLib.searchNameAndGetText(tabControl1, "textBoxPP") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxAWF") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxSDDB") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxDCACycle") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxOWF") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxSDM") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxTGTF") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxSDE") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxSDLT") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxSDFC") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxSDDC") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxD2MWATSD") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxADE") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxADSTT") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxD2MWDC");
                    break;
                case "Global B":         // Global B
                    cmd = SET_GLOBAL_B;
                    mess = CtrlLib.searchNameAndGetText(tabControl1, "textBoxATAT") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxDEFT") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxCWB").Substring(1, 2) +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxBIASW") +
                           CtrlLib.searchNameAndGetText(tabControl1, "textBoxCWB").Substring(0, 1);
                    break;
                case "Message":          // Global A
                    cmd = SET_MESS;
                    mess = CtrlLib.searchNameAndGetText(tabControl1, "textBoxMessage");
                    c1c2Enable = false;
                    break;
                case "Unsolicited Cmd": // Unsolicited Coommand
                    cmd = DISCRETE_OUTPUT_STATE;
                    for (int i = 0; i < 8; i++) {
                        string onoff = "0";
                        switch (i) {
                            case 0:
                                onoff = "10";
                                if (checkBox1.Checked == true) onoff = "11";
                                break;
                            case 1:
                                onoff = "20";
                                if (checkBox2.Checked == true) onoff = "21";
                                break;
                            case 2:
                                onoff = "30";
                                if (checkBox3.Checked == true) onoff = "31";
                                break;
                            case 3:
                                onoff = "40";
                                if (checkBox4.Checked == true) onoff = "41";
                                break;
                            case 4:
                                onoff = "50";
                                if (checkBox5.Checked == true) onoff = "51";
                                break;
                            case 5:
                                onoff = "60";
                                if (checkBox6.Checked == true) onoff = "61";
                                break;
                            case 6:
                                onoff = "70";
                                if (checkBox7.Checked == true) onoff = "71";
                                break;
                            case 7:
                               onoff = "80";
                                if (checkBox8.Checked == true) onoff = "81";
                                break;
                        }
                        sendCommand(cmd, onoff, false);
                    }
                    return;
                default:
                    break;
            }
            if (c1c2Enable == false) {
                c1c2 = "";
            }
            else if (radioButtonC2.Checked == true) {
                c1c2 = "1";
            }

            SendData( adrs + "3" + cmd + c1c2 + mess);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            sendReqEnabled();
        }

        private void sendReqEnabled() {
            if (serialPort1.IsOpen || tClient != null) {
                if (tabControl1.TabPages[tabControl1.SelectedIndex].Text == "Stale Lockout") {
                    buttonSend.Enabled = false;
                    buttonReq.Enabled = true;
                    groupBox_ChSelect.Enabled = true;
                }
                else if (tabControl1.TabPages[tabControl1.SelectedIndex].Text == "Message") {
                    buttonSend.Enabled = true;
                    buttonReq.Enabled = false;
                    groupBox_ChSelect.Enabled = false;
                }
                else if (tabControl1.TabPages[tabControl1.SelectedIndex].Text == "Unsolicited Cmd") {
                    buttonSend.Enabled = true;
                    buttonReq.Enabled = true;
                    groupBox_ChSelect.Enabled = false;
                }
                else if (tabControl1.TabPages[tabControl1.SelectedIndex].Text == "Last 50/75") {
                    buttonSend.Enabled = false;
                    buttonReq.Enabled = false;
                    groupBox_ChSelect.Enabled = true;
                }
                else {
                    buttonSend.Enabled = true;
                    buttonReq.Enabled = true;
                    groupBox_ChSelect.Enabled = true;
                }
            }
        }
        private void sendCommand(String cmd,string Param,bool c1c2_enable) {
            string c1c2 = "0";
            string adrs = adrsConv(); //textBoxDEST.Text;
            if (radioButtonC2.Checked == true) {
                c1c2 = "1";
            }
            if (c1c2_enable == false) c1c2 = "";
            string mess = adrs + "3" + cmd + c1c2;
            if (Param != "") {
                mess += Param;
            }
            SendData(mess);
        }
        private void sendCommandEx(String adrs, String Cmd, String c1c2, String Param) {
            if (tClient != null) {
                adrs = "";
            }
            string mess = adrs + "3" + Cmd + c1c2;
                if (Param != "") {
                mess += Param;
            }
            SendData(mess);
        }

        private void buttonSampleKeyReset_Click(object sender, EventArgs e) {
            string strc1c2 = "C1";

            if (radioButtonC2.Checked == true) {
                strc1c2 = "C2";
            }
            sendCommand(SAMPLE_COLLECT_KEY_RESET, "",true);
            setTextBox("textBoxLast50", DateTime.Now.ToString() + " [" + strc1c2 + "] " + "Sample Collect Key Reset\r\n");
        }

        private void buttonLast50Req_Click(object sender, EventArgs e) {
            string strc1c2 = "C1";

            string msg = "75";
            if (radioButtonC2.Checked == true) {
                strc1c2 = "C2";
            }
            String Cmd = LAST75_REQ;           // Lat 75 Request
            if (radioButtonLast50.Checked == true) {
                Cmd = LAST50_REQ;              // lat 50 request
                msg = "50";
            }
            sendCommand(Cmd, "",true);
            setTextBox("textBoxLast50", DateTime.Now.ToString() + " [" + strc1c2 + "] " + "Last " + msg + "Request\r\n");
        }

        private void checkBoxAutoKeyRset_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAutoKeyRset.Checked == true) {
                buttonSampleKeyReset.Enabled = false;
            }
            else {
                buttonSampleKeyReset.Enabled = true;
            }
        }

        private void checkBoxAutoRequest_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAutoRequest.Checked == true) {
                buttonLast50Req.Enabled = false;
            }
            else {
                buttonLast50Req.Enabled = true;
            }

        }

        static int relay = 1;
        string onoff = "0";

        private void checkBoxAutoOut_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoOut.Checked == true) {
                if (tClient == null) return;
                if (tClient.IsClosed) return;
                
                for(int i=0;i<8;i++) {
                    sendCommand(DISCRETE_OUTPUT_STATE, (i+1).ToString() + "0", false);
                }

                timer2.Start();
                relay = 1;
                onoff = "0";
            }
            else {
                timer2.Stop();
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            bool[] enable = new bool[8]; 

            if (tClient == null)  return;
            if (tClient.IsClosed) return;
            if (relay > 8) relay = 1;

            enable[0] = checkBox1.Checked;
            enable[1] = checkBox2.Checked;
            enable[2] = checkBox3.Checked;
            enable[3] = checkBox4.Checked;
            enable[4] = checkBox5.Checked;
            enable[5] = checkBox6.Checked;
            enable[6] = checkBox7.Checked;
            enable[7] = checkBox8.Checked;

            int i;
            for (i = 0; i < 8; i++) { 
                if (enable[relay - 1] == true) break;
                relay++;
                if (relay > 8) relay = 1;
            }
            if (i >= 8) return;

            if (onoff == "1") {
                onoff = "0";
                sendCommand(DISCRETE_OUTPUT_STATE, relay.ToString() + onoff, false);
                relay++;
                int t;
                try {
                    t = int.Parse(textBox_R_interval.Text);
                }
                catch (Exception) { 
                    t = 1;
                }
                if (t <= 0) t = 1;
                timer2.Interval = t;
            }
            else {
                onoff = "1";
                sendCommand(DISCRETE_OUTPUT_STATE, relay.ToString() + onoff, false);
                int t;
                try {
                    t = int.Parse(textBox_R_oneshot.Text);
                }
                catch (Exception) {
                    t = 1;
                }
                if (t <= 0) t = 1;
                timer2.Interval = t;
            }
        }
    }
}

