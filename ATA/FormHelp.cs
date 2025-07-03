using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace AtaTest {
    public partial class FormHelp : Form {
        string ishida1 = "\r\n ATA Test Tool\r\n     \r\n\r\n ISHIDA Co.,Ltd.\r\n\r\n Version. 2021.OCT.08 M.Yonetsu";
        string ishida2 = "    ";
        public FormHelp() {
            InitializeComponent();
            textBoxIshida.AppendText(ishida1);
            textBoxNplot.AppendText(ishida2);
            buttonHelpOk.Focus();
        }
        private void buttonHelpOk_Click(object sender, EventArgs e) {
            this.Visible = false;
        }
    }
}
