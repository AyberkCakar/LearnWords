namespace KelimeOgren
{
    partial class FrmKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayit));
            this.rdbYetkili = new System.Windows.Forms.RadioButton();
            this.rdbUye = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtYetki = new System.Windows.Forms.TextBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // rdbYetkili
            // 
            this.rdbYetkili.AutoSize = true;
            this.rdbYetkili.BackColor = System.Drawing.Color.Transparent;
            this.rdbYetkili.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbYetkili.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbYetkili.Location = new System.Drawing.Point(248, 125);
            this.rdbYetkili.Name = "rdbYetkili";
            this.rdbYetkili.Size = new System.Drawing.Size(105, 25);
            this.rdbYetkili.TabIndex = 98;
            this.rdbYetkili.TabStop = true;
            this.rdbYetkili.Text = "Yetkili";
            this.rdbYetkili.UseVisualStyleBackColor = false;
            this.rdbYetkili.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbUye
            // 
            this.rdbUye.AutoSize = true;
            this.rdbUye.BackColor = System.Drawing.Color.Transparent;
            this.rdbUye.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbUye.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbUye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbUye.Location = new System.Drawing.Point(151, 125);
            this.rdbUye.Name = "rdbUye";
            this.rdbUye.Size = new System.Drawing.Size(61, 25);
            this.rdbUye.TabIndex = 97;
            this.rdbUye.TabStop = true;
            this.rdbUye.Text = "Üye";
            this.rdbUye.UseVisualStyleBackColor = false;
            this.rdbUye.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(170, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 57);
            this.label1.TabIndex = 99;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(83, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 57);
            this.label2.TabIndex = 100;
            this.label2.Text = "_____________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(124, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 101;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(91, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 102;
            this.label4.Text = "Sifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(14, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Kullanıcı ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label6.Location = new System.Drawing.Point(102, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 104;
            this.label6.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label7.Location = new System.Drawing.Point(69, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label8.Location = new System.Drawing.Point(91, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 106;
            this.label8.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtAd.Location = new System.Drawing.Point(164, 208);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(210, 28);
            this.txtAd.TabIndex = 107;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoyad.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtSoyad.Location = new System.Drawing.Point(164, 248);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(210, 28);
            this.txtSoyad.TabIndex = 108;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtMail.Location = new System.Drawing.Point(164, 324);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(210, 28);
            this.txtMail.TabIndex = 110;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtKullaniciID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKullaniciID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtKullaniciID.Location = new System.Drawing.Point(164, 362);
            this.txtKullaniciID.Multiline = true;
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(210, 28);
            this.txtKullaniciID.TabIndex = 111;
            this.txtKullaniciID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSifre.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtSifre.Location = new System.Drawing.Point(164, 400);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(210, 28);
            this.txtSifre.TabIndex = 112;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYetki
            // 
            this.txtYetki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtYetki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYetki.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtYetki.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtYetki.Location = new System.Drawing.Point(164, 446);
            this.txtYetki.Multiline = true;
            this.txtYetki.Name = "txtYetki";
            this.txtYetki.Size = new System.Drawing.Size(210, 28);
            this.txtYetki.TabIndex = 114;
            this.txtYetki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.lblYetki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.lblYetki.Location = new System.Drawing.Point(91, 446);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(76, 21);
            this.lblYetki.TabIndex = 113;
            this.lblYetki.Text = "Yetki:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(491, -2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(32, 52);
            this.simpleButton3.TabIndex = 115;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(105, 533);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(315, 50);
            this.simpleButton2.TabIndex = 116;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.mskTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.mskTelefon.Location = new System.Drawing.Point(164, 287);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(210, 27);
            this.mskTelefon.TabIndex = 117;
            // 
            // FrmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(530, 678);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.txtYetki);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbYetkili);
            this.Controls.Add(this.rdbUye);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKayit";
            this.Text = "FrmKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbYetkili;
        private System.Windows.Forms.RadioButton rdbUye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtYetki;
        private System.Windows.Forms.Label lblYetki;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
    }
}