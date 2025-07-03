using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyLib {
    class RcvData {

        const int RCV_BUFF_MAX = 1024;
        byte[] RcvBuff = new byte[RCV_BUFF_MAX];

        int DataCount = 0;
        int GetPtr = 0;
        int PutPtr = 0;

        public int RcvStatus;
        public byte ctrlCode_stx = 0x0a;
        public byte ctrlCode_etx = 0x0d;

        public enum RCVSTAT : int {
            OK,
            NONE,
            NO_STX,
            NO_ETX,
            LENGS_TOO_LONG,
            BCC_ERROR,
            CNV_ERROR
        }

        public RcvData() {
            this.clear();
        }

        public void clear() {
            DataCount = 0;
            GetPtr = 0;
            PutPtr = 0;
        }

        public void SetCtrlCode(byte stx, byte etx) {
            ctrlCode_stx = stx;
            ctrlCode_etx = etx;
        }

        public byte getStx() {
            return ctrlCode_stx;
        }
        public byte getEtx() {
            return ctrlCode_etx;
        }


        public int AddRcvData(byte[] dat,int len) {
            int i;

            for(i=0; i<len; i++) {
                if (PutPtr >= RCV_BUFF_MAX) {
                    PutPtr = 0;
                }
                RcvBuff[PutPtr] = dat[i];
                PutPtr++;
                if (PutPtr >= RCV_BUFF_MAX) {
                    PutPtr = 0;
                }
                if (dat[i] == (byte)ctrlCode_etx) {   // ETX
                    DataCount++;
                }
                if (PutPtr == GetPtr) { // Bauffer Over
                    this.clear();
                    return -1 * i;
                } 
            }
            return len;
        }

        public string GetRcvData() {
            byte[] Buf = new byte[1024];
            int i,len=0;

            RcvStatus = (int)RCVSTAT.NONE;

            while (DataCount > 0) {
                for (i = 0; i < 1024; i++) {
                    Buf[i] = 0;
                }
                for (i = 0; i < Buf.GetLength(0); i++) {
                    Buf[i] = RcvBuff[GetPtr];
                    GetPtr++;
                    if (GetPtr >= RCV_BUFF_MAX) {
                        GetPtr = 0;
                    }
                    len++;
                    if (Buf[i] == (byte)ctrlCode_etx) {
                        DataCount--;
                        Buf[i] = (byte)'\0';
                        RcvStatus = (int)RCVSTAT.OK;
                        break;
                    } else if (GetPtr == PutPtr) {
                        DataCount = 0;
                        RcvStatus = (int)RCVSTAT.NO_ETX;
                        break;
                    }
                }
                if (RcvStatus == (int)RcvData.RCVSTAT.NONE) {
                    RcvStatus = (int)RcvData.RCVSTAT.LENGS_TOO_LONG;
                }

                if (RcvStatus == (int)RcvData.RCVSTAT.OK) {

                    Encoding ascii = Encoding.ASCII;
                    Encoding unicode = Encoding.Unicode;
                    // Perform the conversion from one encoding to the other.
                    byte[] unicodeBytes = Encoding.Convert(ascii, unicode, Buf);
                    string rcvString = Encoding.Unicode.GetString(unicodeBytes);
                    string[] split = rcvString.Split(new string[] { "\r", "\n", "\0", "\x02", "\x03" }, StringSplitOptions.RemoveEmptyEntries);
                    return split[0];
                }
            }
            return null;
        }
        
        public int GetCnt() {
            return DataCount;
        }
    }
}
