using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Ports;

namespace MyLib {

    [Serializable()]
    public class Settings
    {
        //設定を保存するフィールド

        private int _BaudRate;
        private int _DataBits;
        private Parity _Parity;
        private StopBits _StopBits;
        private string _PortName;
        private string _DataPath;

        //設定のプロパティ
        public int BaudRate
        {
            get { return _BaudRate; }
            set { _BaudRate = value; }
        }
        public int DataBits
        {
            get { return _DataBits; }
            set { _DataBits = value; }
        }

        public Parity Parity {
            get { return _Parity; }
            set { _Parity = value; }
        }

        public StopBits StopBits {
            get { return _StopBits; }
            set { _StopBits = value; }
        }

        public string PortName {
            get { return _PortName; }
            set { _PortName = value; }
        }

        public string DataPath {
            get { return _DataPath; }
            set { _DataPath = value; }
        }

        //コンストラクタ
        public Settings()
        {
            _BaudRate = 57600;
            _DataBits = 8;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _PortName = "COM3";
            _DataPath = "C:\\";
        }

        //Settingsクラスのただ一つのインスタンス
        [NonSerialized()]
        private static Settings _instance;
        [System.Xml.Serialization.XmlIgnore]
        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Settings();
                return _instance;
            }
            set { _instance = value; }
        }

        /// <summary>
        /// 設定をXMLファイルから読み込み復元する
        /// </summary>
        public static void LoadFromXmlFile()
        {
            string path = GetSettingPath();
            FileStream fs = null;

            try {
                fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                System.Xml.Serialization.XmlSerializer xs =
                    new System.Xml.Serialization.XmlSerializer(
                        typeof(Settings));
                //読み込んで逆シリアル化する
                object obj = xs.Deserialize(fs);
                fs.Close();
                Instance = (Settings)obj;
            } catch (Exception ex) {
                if(fs != null)                fs.Close();
                //例外をキャッチした時
                //例外を説明するメッセージを表示
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 現在の設定をXMLファイルに保存する
        /// </summary>
        public static void SaveToXmlFile()
        {
            string path = GetSettingPath();
            FileStream fs = null;

            try {
                fs = new FileStream(path,FileMode.Create,FileAccess.Write);
                System.Xml.Serialization.XmlSerializer xs =
                    new System.Xml.Serialization.XmlSerializer(
                    typeof(Settings));
                //シリアル化して書き込む
                xs.Serialize(fs, Instance);
                fs.Close();
            } catch (Exception ex) {
                if (fs != null)   fs.Close();
                //例外を説明するメッセージを表示
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        public static string GetSettingPath()
        {
            GetPath p = new GetPath();

            string path = p.AppDir + p.AppNameWithOutExtention + ".config";
            return path;
        }
    }
}
