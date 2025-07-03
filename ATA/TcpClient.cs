﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace AtaTest {

    public class TcpClient {
        /** プライベート変数 **/
        //Socket
        private Socket mySocket = null;

        //受信データ保存用
        private MemoryStream myMs;

        //ロック用
        private readonly object syncLock = new object();

        //送受信文字列エンコード
        private Encoding enc = Encoding.UTF8;


        /** イベント **/
        //データ受信イベント
        public delegate void ReceiveEventHandler(byte[] b, int len);
        public event ReceiveEventHandler OnReceiveData;

        //接続断イベント
        public delegate void DisconnectedEventHandler(object sender, EventArgs e);
        public event DisconnectedEventHandler OnDisconnected;

        //接続OKイベント
        public delegate void ConnectedEventHandler(EventArgs e);
        public event ConnectedEventHandler OnConnected;

        /** プロパティ **/
        /// <summary>
        /// ソケットが閉じているか
        /// </summary>
        public bool IsClosed {
            get { return (mySocket == null); }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public virtual void Dispose() {
            //Socketを閉じる
            Close();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TcpClient() {
            //Socket生成
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public TcpClient(Socket sc) {
            mySocket = sc;
        }

        /// <summary>
        /// SocketClose
        /// </summary>
        public void Close() {

            if (mySocket == null) return;

            Console.WriteLine("Close" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);

            //Socketを無効
            mySocket.Shutdown(SocketShutdown.Both);
            //Socketを閉じる
            mySocket.Close();
            mySocket = null;

            //受信データStreamを閉じる
            if (myMs != null) {
                myMs.Close();
                myMs = null;
            }

            //接続断イベント発生
            OnDisconnected(this, new EventArgs());
        }

        /// <summary>
        /// Hostに接続
        /// </summary>
        /// <param name="host">接続先ホスト</param>
        /// <param name="port">ポート</param>
        public void Connect(string host, int port) {

            Console.WriteLine("Connect" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);

            //IP作成
            IPEndPoint ipEnd = new IPEndPoint(Dns.GetHostAddresses(host)[0], port);
            //ホストに接続
            try {
                mySocket.BeginConnect(ipEnd,
                    new AsyncCallback(ConnectCallback), mySocket);
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private void ConnectCallback(IAsyncResult ar) {
            Console.WriteLine("ConnectCallback" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);
            try {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                //接続OKイベント発生
                OnConnected(new EventArgs());
                //データ受信開始
                StartReceive();
            } catch (Exception e) {
                OnDisconnected(this, new EventArgs());
                Console.WriteLine("接続エラー");
                Console.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// データ受信開始
        /// </summary>
        public void StartReceive() {
            Console.WriteLine("StartReceive" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);

            //受信バッファ
            byte[] rcvBuff = new byte[1024];
            //受信データ初期化
            myMs = new MemoryStream();

            //非同期データ受信開始
            mySocket.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(
                ReceiveDataCallback), rcvBuff);
        }

        /// <summary>
        /// 非同期データ受信
        /// </summary>
        /// <param name="ar"></param>
        private void ReceiveDataCallback(IAsyncResult ar) {
            Console.WriteLine("ReceiveDataCallback" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);

            int len = -1;
            lock (syncLock) {
                if (IsClosed)
                    return;

                //データ受信終了
                try {
                    len = mySocket.EndReceive(ar);
                } catch (Exception ex) {
                    Console.WriteLine(ex);
                    return;
                }

            }

            //切断された
            if (len <= 0) {
                Close();
                return;
            }

            //受信データ取り出し
            byte[] rcvBuff = (byte[])ar.AsyncState;

            OnReceiveData(rcvBuff,len);


            //受信データ保存
            /*
                        myMs.Write(rcvBuff, 0, len);

                        if (myMs.Length >= 2) {
                            //\r\nかチェック
                            myMs.Seek(-2, SeekOrigin.End);
                            if (myMs.ReadByte() == FormAtaTest.ETX) {
                                //受信データを文字列に変換
                                string rsvStr = enc.GetString(myMs.ToArray());
                                //受信データ初期化
                                myMs.Close();
                                myMs = new MemoryStream();

                                //データ受信イベント発生
                                OnReceiveData(this, rsvStr);

                            } else {
                                //ストリーム位置を戻す
                                myMs.Seek(0, SeekOrigin.End);
                            }
                        }
             */
            lock (syncLock) {
                //非同期受信を再開始
                if (!IsClosed)
                    mySocket.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(ReceiveDataCallback), rcvBuff);
            }
        }

        /// <summary>
        /// メッセージを送信する
        /// </summary>
        /// <param name="str"></param>
        public void Send(byte[] sendBytes,int len) {
            Console.WriteLine("Send" + " ThreadID:" + Thread.CurrentThread.ManagedThreadId);

            if (!IsClosed) {
               lock (syncLock) {
                    //送信
                    mySocket.Send(sendBytes, len, SocketFlags.None);
                }
            }
        }
    }
}