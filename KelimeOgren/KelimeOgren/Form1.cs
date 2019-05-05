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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kelime kelime = new Kelime();
        Uye oyun = new Uye("ayberk");
        OyunOyna oyun1 = new OyunOyna();
        private void Form1_Load(object sender, EventArgs e)
        {
            RadioSıfırla();
            kelime.KelimeOgren();
            KelimeGetir(0);
            oyun.OyunBilgileriniGetir(oyun1);
        }
        int sayi, kontrol=0;
        private void btnEVLA_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnKelimeOgren_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void btnOgrenmismiyim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;

        }

        private void btnOgrendiklerim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sayac = 0;

        void KelimeGetir(int say)
        {
            Kelime kelime = new Kelime();
            kelime= this.kelime.UyeKelimeOgren(say);
            lblTur.Text =kelime.Turu;
            lblKelime.Text = kelime.Turkce;
            lblIng.Text = kelime.Ingilizce;
            lblOrn.Text = kelime.OrnCumle;
            lblOrnTurk.Text = kelime.TurkceCumle;
            pictureBox1.ImageLocation = kelime.Resim;          
        }
        private void btnOgrenBack_Click(object sender, EventArgs e)
        {
            sayac--;
            if(sayac==-1)
            {
                sayac = 0;
            }
            else
            {
                KelimeGetir(sayac);
            }  
        }
        private void btnOgrenNext_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= kelime.Kelimeler.Count()  || sayac == kelime.Kelimeler.Count() )
                sayac = kelime.Kelimeler.Count() - 1;
            else
                KelimeGetir(sayac);  
        }
        int saniye = 15;
        private void btnKelimeNext_Click(object sender, EventArgs e)
        {
            kontrol++;
            KelimeOyunu();
            saniye = 15;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            lblSaniye.Text = saniye.ToString();
            RadioSıfırla();
            picTrue.Visible = false;
            picFalse.Visible = false;
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblSaniye.Text = saniye.ToString();
            if (saniye == 0 && (rdA.Checked == false && rdB.Checked == false && rdC.Checked == false && rdD.Checked == false))
            {
                timer1.Enabled = false;
                picFalse.Visible = true;
                picTrue.Visible = false;
            }
            else if (saniye == 0)
                timer1.Enabled = true;
        }
        void RadioSıfırla()
        {
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
            rdA.Enabled = true;
            rdB.Enabled = true;
            rdC.Enabled = true;
            rdD.Enabled = true;
        }
        
        void KelimeOyunu()
        {

            if (oyun1.Game.Count < kontrol)
            {
                btnKelimeNext.Enabled = false;
                panel1.Visible = true;
                lblSon.Visible = true;
            }
            else
            {
                OyunOyna GameBasla = new OyunOyna();
                GameBasla = this.oyun1.Oyun(kontrol);
                Random rd = new Random();
                sayi = rd.Next(1, 5);
                if (sayi == 1)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblA.Text = GameBasla.Ingilizce;
                }
                else if (sayi == 2)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblB.Text = GameBasla.Ingilizce;
                }
                else if (sayi == 3)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblC.Text = GameBasla.Ingilizce;
                }
                else if (sayi == 4)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblD.Text = GameBasla.Ingilizce;
                }
            }
        }
        void Kontrol()
        {
            if (sayi == 1)
            {
                if (rdA.Checked == true)
                {
                    picTrue.Visible = true;
                }
                else
                {
                    picFalse.Visible = true;
                }

            }
            else if (sayi == 2)
            {
                if (rdB.Checked == true)
                {
                    picTrue.Visible = true;
                }
                else
                {
                    picFalse.Visible = true;
                }
            }
            else if (sayi == 3)
            {
                if (rdC.Checked == true)
                {
                    picTrue.Visible = true;
                }
                else
                {
                    picFalse.Visible = true;
                }
            }
            else if (sayi == 4)
            {
                if (rdD.Checked == true)
                {
                    picTrue.Visible = true;
                }
                else
                {
                    picFalse.Visible = true;
                }
            }
        }

        private void rdA_CheckedChanged(object sender, EventArgs e)
        {
            Kontrol();
            rdB.Enabled = false;
            rdC.Enabled = false;
            rdD.Enabled = false;
            timer1.Stop();
        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {
            Kontrol();
            rdA.Enabled = false;
            rdC.Enabled = false;
            rdD.Enabled = false;
            timer1.Stop();

        }

        private void rdC_CheckedChanged(object sender, EventArgs e)
        {
            Kontrol();
            rdB.Enabled = false;
            rdA.Enabled = false;
            rdD.Enabled = false;
            timer1.Stop();
        }

        private void rdD_CheckedChanged(object sender, EventArgs e)
        {
            Kontrol();
            rdB.Enabled = false;
            rdC.Enabled = false;
            rdA.Enabled = false;
            timer1.Stop();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnBasla.Visible = false;
        }
    }
}
