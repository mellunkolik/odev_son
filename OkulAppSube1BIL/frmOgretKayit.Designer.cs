namespace OkulAppSube1BIL
{
    partial class frmOgretKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.btnKaydet);
            this.grpOgretmen.Controls.Add(this.lblTc);
            this.grpOgretmen.Controls.Add(this.lblSoyad);
            this.grpOgretmen.Controls.Add(this.lblAd);
            this.grpOgretmen.Controls.Add(this.txtTc);
            this.grpOgretmen.Controls.Add(this.txtSoyad);
            this.grpOgretmen.Controls.Add(this.txtAd);
            this.grpOgretmen.Location = new System.Drawing.Point(13, 13);
            this.grpOgretmen.Margin = new System.Windows.Forms.Padding(4);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Padding = new System.Windows.Forms.Padding(4);
            this.grpOgretmen.Size = new System.Drawing.Size(432, 275);
            this.grpOgretmen.TabIndex = 1;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(93, 162);
            this.lblTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(23, 16);
            this.lblTc.TabIndex = 5;
            this.lblTc.Text = "Tc";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(93, 132);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(93, 97);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(163, 159);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(132, 22);
            this.txtTc.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(163, 123);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(163, 89);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(151, 209);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOgretKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 311);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgretKayit";
            this.Text = "Form1";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKaydet;
    }
}