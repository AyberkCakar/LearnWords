namespace KelimeOgren
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.rdbUye = new System.Windows.Forms.RadioButton();
            this.rdbYetkili = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(328, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtKullaniciID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKullaniciID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtKullaniciID.Location = new System.Drawing.Point(256, 235);
            this.txtKullaniciID.Multiline = true;
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(301, 28);
            this.txtKullaniciID.TabIndex = 88;
            this.txtKullaniciID.Text = "Kullanıcı ID";
            this.txtKullaniciID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKullaniciID.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSifre.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtSifre.Location = new System.Drawing.Point(256, 277);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.Size = new System.Drawing.Size(301, 28);
            this.txtSifre.TabIndex = 89;
            this.txtSifre.Text = "Sifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnKayit.Image")));
            this.btnKayit.Location = new System.Drawing.Point(243, 400);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(319, 52);
            this.btnKayit.TabIndex = 91;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.btnGiris.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGiris.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearancePressed.Options.UseBackColor = true;
            this.btnGiris.AppearancePressed.Options.UseBorderColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(245, 338);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(319, 52);
            this.btnGiris.TabIndex = 92;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(776, -2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(32, 52);
            this.simpleButton3.TabIndex = 93;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // rdbUye
            // 
            this.rdbUye.AutoSize = true;
            this.rdbUye.BackColor = System.Drawing.Color.Transparent;
            this.rdbUye.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbUye.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbUye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbUye.Location = new System.Drawing.Point(311, 192);
            this.rdbUye.Name = "rdbUye";
            this.rdbUye.Size = new System.Drawing.Size(61, 25);
            this.rdbUye.TabIndex = 95;
            this.rdbUye.TabStop = true;
            this.rdbUye.Text = "Üye";
            this.rdbUye.UseVisualStyleBackColor = false;
            // 
            // rdbYetkili
            // 
            this.rdbYetkili.AutoSize = true;
            this.rdbYetkili.BackColor = System.Drawing.Color.Transparent;
            this.rdbYetkili.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbYetkili.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbYetkili.Location = new System.Drawing.Point(408, 192);
            this.rdbYetkili.Name = "rdbYetkili";
            this.rdbYetkili.Size = new System.Drawing.Size(105, 25);
            this.rdbYetkili.TabIndex = 96;
            this.rdbYetkili.TabStop = true;
            this.rdbYetkili.Text = "Yetkili";
            this.rdbYetkili.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(233, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 57);
            this.label2.TabIndex = 101;
            this.label2.Text = "_____________";
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 657);
            this.Controls.Add(this.rdbYetkili);
            this.Controls.Add(this.rdbUye);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnKayit;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.RadioButton rdbUye;
        private System.Windows.Forms.RadioButton rdbYetkili;
        private System.Windows.Forms.Label label2;
    }
}