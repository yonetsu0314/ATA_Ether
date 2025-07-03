using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;

namespace MyLib {
    class CtrlLib {
        /// --------------------------------------------------------------------------------
        /// <summary>
        ///     指定したコントロール内に含まれる TextBox の Text をクリアする。</summary>
        /// <param name="hParent">
        ///     検索対象となる親コントロール。</param>
        /// --------------------------------------------------------------------------------
        public static void ClearTextBox(Control hParent) {
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control cControl in hParent.Controls) {
                // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                if (cControl.HasChildren == true) {
                    ClearTextBox(cControl);
                }

                // コントロールの型が TextBoxBase からの派生型の場合は Text をクリアする
                if (cControl is TextBoxBase) {
                    cControl.Text = string.Empty;
                }
            }
        }
        /// --------------------------------------------------------------------------------
        /// <summary>
        ///     指定したコントロール内に含まれる RadioButton の チェックを外す。</summary>
        /// <param name="hParent">
        ///     検索対象となる親コントロール。</param>
        /// --------------------------------------------------------------------------------
        public static void ClearRadioButton(Control hParent) {
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control cControl in hParent.Controls) {
                // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                if (cControl.HasChildren == true) {
                    ClearRadioButton(cControl);
                }

                // コントロールの型が RadioButton ならチェックを外す
                if (cControl is RadioButton) {
                    RadioButton r = (RadioButton)cControl;
                    r.Checked = false;
                }
            }
        }
        /// --------------------------------------------------------------------------------
        /// <summary>
        ///     指定したコントロール内に含まれる Button を Enable/Disable にする。</summary>
        /// <param name="hParent">
        ///     検索対象となる親コントロール。</param>
        /// --------------------------------------------------------------------------------
        public static void EnableButton(Control hParent) {
            CtrlButton(hParent, true);
        }
        public static void DisableButton(Control hParent) {
            CtrlButton(hParent, false);
        }

        private static void CtrlButton(Control hParent, bool stat) {
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control cControl in hParent.Controls) {
                // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                if (cControl.HasChildren == true) {
                    CtrlButton(cControl, stat);
                }

                // コントロールの型が RadioButton ならチェックを外す
                if (cControl is Button) {
                    cControl.Enabled = stat;
                }
            }
        }

        /// --------------------------------------------------------------------------------
        /// <summary>
        ///     指定したコントロール内に含まれる TextBox名をnameと比較し同じなら 
        ///     TextBox.Textにmessを設定する。</summary>
        /// <param name="hParent">
        ///     検索対象となる親コントロール、TextBox名、設定する文字列。</param>
        /// --------------------------------------------------------------------------------
        public static bool searchNameAndSetText(Control hParent, String name, string mess) {
            bool end = false;
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control cControl in hParent.Controls) {
                // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                if (cControl.HasChildren == true) {
//                    Console.WriteLine(cControl.Name);
                    if (end == false) {
                        end = searchNameAndSetText(cControl, name, mess);
                    }
                }

                // コントロールの型が TextBoxBase からの派生型の場合は Text をセットする
                if (cControl is TextBoxBase) {
//                    Console.WriteLine(cControl.Name);
                    TextBox box = (TextBox)cControl;
                    if (box.Name == name) {
                        if ((string)(box.Tag) == "ADD") {
                            box.AppendText(mess);
                        }
                        else {
                            ((TextBox)cControl).Text = mess;
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        /// --------------------------------------------------------------------------------
        /// <summary>
        ///     指定したコントロール内に含まれる TextBox名をnemeと比較し同じなら 
        ///     TextBoxのTextを返す。</summary>
        /// <param name="hParent">
        ///     検索対象となる親コントロール、TextBox名。</param>
        /// --------------------------------------------------------------------------------
        public static string searchNameAndGetText(Control hParent, String name) {
            string text = null;
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control cControl in hParent.Controls) {
                // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                if (cControl.HasChildren == true) {
                    Console.WriteLine(cControl.Name);
                    if (text == null) {
                        text = searchNameAndGetText(cControl, name);
                    }
                }

                // コントロールの型が TextBoxBase からの派生型の場合は Text をセットする
                if (cControl is TextBoxBase) {
                    Console.WriteLine(cControl.Name);
                    if ((string)((TextBox)cControl).Name == name) {
                        return ((TextBox)cControl).Text;
                    }
                }
            }
            return text;
        }
    }

 //--------------------------------------------------------------------------------------

    class TabPageManager {
        private class TabPageInfo {
            public TabPage TabPage;
            public bool Visible;
            public TabPageInfo(TabPage page, bool v) {
                TabPage = page;
                Visible = v;
            }
        }
        private TabPageInfo[] _tabPageInfos = null;
        private TabControl _tabControl = null;

        /// <summary>
        /// TabPageManagerクラスのインスタンスを作成する
        /// </summary>
        /// <param name="crl">基になるTabControlオブジェクト</param>
        public TabPageManager(TabControl crl) {
            _tabControl = crl;
            _tabPageInfos = new TabPageInfo[_tabControl.TabPages.Count];
            for (int i = 0; i < _tabControl.TabPages.Count; i++)
                _tabPageInfos[i] =
                    new TabPageInfo(_tabControl.TabPages[i], true);
        }

        /// <summary>
        /// TabPageの表示・非表示を変更する
        /// </summary>
        /// <param name="index">変更するTabPageのIndex番号</param>
        /// <param name="v">表示するときはTrue。
        /// 非表示にするときはFalse。</param>
        public void ChangeTabPageVisible(int index, bool v) {
            if (_tabPageInfos[index].Visible == v)
                return;

            _tabPageInfos[index].Visible = v;
            _tabControl.SuspendLayout();
            _tabControl.TabPages.Clear();
            for (int i = 0; i < _tabPageInfos.Length; i++) {
                if (_tabPageInfos[i].Visible)
                    _tabControl.TabPages.Add(_tabPageInfos[i].TabPage);
            }
            _tabControl.ResumeLayout();
        }
    }
}
