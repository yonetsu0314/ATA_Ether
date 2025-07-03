namespace AtaTest {
    partial class FormHelp {
        /// <summary>
        /// 必要なデザイナー変数です。
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.textBoxNplot = new System.Windows.Forms.TextBox();
            this.buttonHelpOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxIshida = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNplot
            // 
            this.textBoxNplot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNplot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNplot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNplot.Location = new System.Drawing.Point(29, 176);
            this.textBoxNplot.Multiline = true;
            this.textBoxNplot.Name = "textBoxNplot";
            this.textBoxNplot.ReadOnly = true;
            this.textBoxNplot.Size = new System.Drawing.Size(235, 55);
            this.textBoxNplot.TabIndex = 10;
            this.textBoxNplot.Text = " ";
            // 
            // buttonHelpOk
            // 
            this.buttonHelpOk.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelpOk.Location = new System.Drawing.Point(88, 237);
            this.buttonHelpOk.Name = "buttonHelpOk";
            this.buttonHelpOk.Size = new System.Drawing.Size(113, 24);
            this.buttonHelpOk.TabIndex = 9;
            this.buttonHelpOk.Text = "OK";
            this.buttonHelpOk.UseVisualStyleBackColor = false;
            this.buttonHelpOk.Click += new System.EventHandler(this.buttonHelpOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxIshida
            // 
            this.textBoxIshida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIshida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIshida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIshida.Location = new System.Drawing.Point(12, 11);
            this.textBoxIshida.Multiline = true;
            this.textBoxIshida.Name = "textBoxIshida";
            this.textBoxIshida.ReadOnly = true;
            this.textBoxIshida.Size = new System.Drawing.Size(268, 86);
            this.textBoxIshida.TabIndex = 7;
            this.textBoxIshida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textBoxNplot);
            this.Controls.Add(this.buttonHelpOk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxIshida);
            this.Name = "FormHelp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNplot;
        private System.Windows.Forms.Button buttonHelpOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxIshida;
    }
}