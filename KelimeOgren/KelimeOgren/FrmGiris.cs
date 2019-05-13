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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciID.Text == "Kullanıcı ID")
            {
                txtKullaniciID.Text = "";
            } 
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Sifre";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text=="Sifre")
            {
                txtSifre.Text = "";
            }
            if(txtKullaniciID.Text=="")
            {
                txtKullaniciID.Text = "Kullanıcı ID";
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FrmKayit frKayit = new FrmKayit(); //Kayıt sayfası açılsın
            frKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(rdbUye.Checked == true)
            {
                
                GirisServisi giris = new GirisServisi();
                if (giris.GirisYap(txtKullaniciID.Text.ToLower(), txtSifre.Text) != null)
                {
                    Form1 Uye = new Form1();
                    Uye.kullanici = txtKullaniciID.Text.ToLower();
                    Uye.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            else if( rdbYetkili.Checked ==true)
            {
                GirisServisi giris = new GirisServisi();
                if( giris.GirisYapYetkili(txtKullaniciID.Text.ToLower(), txtSifre.Text) != null)
                {
                    FrmYetkili Yetkili = new FrmYetkili();
                    Yetkili.kullanici= txtKullaniciID.Text.ToLower();
                    Yetkili.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }     
            }
            else
            {
                MessageBox.Show("Giriş Türü Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
