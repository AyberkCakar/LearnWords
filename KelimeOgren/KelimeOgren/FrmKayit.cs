using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgren
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblYetki.Visible = true;
            txtYetki.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblYetki.Visible = false;
            txtYetki.Visible = false;
            txtYetki.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (rdbUye.Checked == true)
            {
                Uye newUye = new Uye();
                newUye.Ad = txtAd.Text;
                newUye.Soyad = txtSoyad.Text;
                newUye.Telefon = mskTelefon.Text;
                newUye.Mail = txtMail.Text;
                newUye.KullaniciID = txtKullaniciID.Text;
                newUye.Sifre = txtSifre.Text;
                newUye.KisiEkle();
                MessageBox.Show("Yeni Üye Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rdbYetkili.Checked == true)
            {
                Yetkili newYetkili = new Yetkili();
                newYetkili.Yetki = txtYetki.Text;
                newYetkili.Ad = txtAd.Text;
                newYetkili.Soyad = txtSoyad.Text;
                newYetkili.Telefon = mskTelefon.Text;
                newYetkili.Mail = txtMail.Text;
                newYetkili.KullaniciID = txtKullaniciID.Text;
                newYetkili.Sifre = txtSifre.Text;
                newYetkili.KisiEkle();
                MessageBox.Show("Yeni Yetkili Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt türü seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
        }
    }
}
