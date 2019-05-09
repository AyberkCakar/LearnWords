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
        public string kullanici;
        Kelime kelime = new Kelime();
        OyunOyna oyun1 = new OyunOyna();
        private void Form1_Load(object sender, EventArgs e)
        {
            Uye oyun = new Uye(kullanici);
            RadioSıfırla();
            kelime.KelimeOgren(oyun);
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
            GridTamamlananlarDoldur();
            YıllıkIstatistik();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
            UyeBilgiGetir(kullanici);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sayac = 0, MaxCount;

        void KelimeGetir(int say)
        {
            Kelime kelime = new Kelime();
            kelime= this.kelime.UyeKelimeOgren(say);
            MaxCount = this.kelime.Kelimeler.Count();
            lblTur.Text =kelime.Turu;
            lblKelime.Text = kelime.Turkce;
            lblIng.Text = kelime.Ingilizce;
            lblOrn.Text = kelime.OrnCumle;
            lblOrnTurk.Text = kelime.TurkceCumle;
            pictureBox1.ImageLocation = kelime.Resim;          
        }
        void KelimeOgrenmeKaydet(int say)
        {
            Uye oyun = new Uye(kullanici);
            DateTime dt = DateTime.Today;
            Kelime kelime = new Kelime();
            kelime = this.kelime.UyeKelimeOgren(say);
            oyun1.KelimeID = kelime.KelimeId;
            oyun1.Kelime = kelime.Turkce;
            oyun1.Ingilizce = kelime.Ingilizce;
            oyun1.Resim = kelime.Resim;
            oyun1.KullanıcıID = oyun.kullaniciAdi;
            oyun1.Dt = dt;
            oyun1.KelimeSeviyesi = 1;
            oyun.OyunBilgisiGir(oyun1);
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
            {
                KelimeGetir(sayac);
                KelimeOgrenmeKaydet(sayac);
            }
        }
        int saniye = 15;
        private void btnKelimeNext_Click(object sender, EventArgs e)
        {
            if(picTrue.Visible==true)
            {
                KelimeKontrolUpdateTrue(kelimeID, Seviye);
            }
            else if(picFalse.Visible == true)
            {
                KelimeKontrolUpdateFalse(kelimeID, Seviye);
            }
            OyunuBaslat();
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
        string[] RastgeleKelimeler = new string[3];
        int kelimeID, Seviye;
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
                RastgeleKelime(GameBasla.Ingilizce);
                Random rd = new Random();
                sayi = rd.Next(1, 5);
                if (sayi == 1)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblA.Text = GameBasla.Ingilizce;
                    kelimeID = GameBasla.KelimeID;
                    Seviye = GameBasla.KelimeSeviyesi;
                    lblB.Text = RastgeleKelimeler[0];
                    lblC.Text = RastgeleKelimeler[1];
                    lblD.Text = RastgeleKelimeler[2];
                }
                else if (sayi == 2)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblB.Text = GameBasla.Ingilizce;
                    kelimeID = GameBasla.KelimeID;
                    Seviye = GameBasla.KelimeSeviyesi;
                    lblA.Text = RastgeleKelimeler[0];
                    lblC.Text = RastgeleKelimeler[1];
                    lblD.Text = RastgeleKelimeler[2];
                }
                else if (sayi == 3)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblC.Text = GameBasla.Ingilizce;
                    kelimeID = GameBasla.KelimeID;
                    Seviye = GameBasla.KelimeSeviyesi;
                    lblA.Text = RastgeleKelimeler[0];
                    lblB.Text = RastgeleKelimeler[1];
                    lblD.Text = RastgeleKelimeler[2];
                }
                else if (sayi == 4)
                {
                    picOyun.ImageLocation = GameBasla.Resim;
                    lblSeciliKelime.Text = GameBasla.Kelime;
                    lblD.Text = GameBasla.Ingilizce;
                    kelimeID = GameBasla.KelimeID;
                    Seviye = GameBasla.KelimeSeviyesi;
                    lblA.Text = RastgeleKelimeler[0];
                    lblB.Text = RastgeleKelimeler[1];
                    lblC.Text = RastgeleKelimeler[2];
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
            OyunuBaslat();
        }
        void OyunuBaslat()
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
        void KelimeKontrolUpdateTrue(int KelimeID,int Kademe)
        {
            Uye oyun = new Uye(kullanici);
            DateTime dt = DateTime.Today;
            oyun1.KelimeID = KelimeID;
            oyun1.KelimeSeviyesi = Kademe + 1;
            oyun1.Dt = Convert.ToDateTime(dt);
            oyun1.KullanıcıID = oyun.kullaniciAdi;
            oyun.OyunBilgileriniUpdate(oyun1);
        }
        void KelimeKontrolUpdateFalse(int KelimeID, int Kademe)
        {
            Uye oyun = new Uye(kullanici);
            DateTime dt = DateTime.Today;
            oyun1.KelimeID = KelimeID;
            oyun1.KelimeSeviyesi = 1;
            oyun1.Dt = Convert.ToDateTime(dt);
            oyun1.KullanıcıID = oyun.kullaniciAdi;
            oyun.OyunBilgileriniUpdate(oyun1);
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtUSifre.UseSystemPasswordChar == false)
                txtUSifre.UseSystemPasswordChar = true;
            else if (txtUSifre.UseSystemPasswordChar == true)
                txtUSifre.UseSystemPasswordChar = false;
        }

        void RastgeleKelime(string kelime)
        {
            Kelime word = new Kelime();
            word = this.kelime;
            int randomm, sayac=0;
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                randomm = random.Next(0, MaxCount + 1);
                foreach (Kelime klm in word.Kelimeler)
                {
                    if (sayac == randomm)
                    {
                        if (kelime != klm.Ingilizce && RastgeleKelimeler[0] != klm.Ingilizce && klm.Ingilizce != RastgeleKelimeler[1] && klm.Ingilizce != RastgeleKelimeler[2])
                        {
                            RastgeleKelimeler[i] = klm.Ingilizce;
                            sayac = 0;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        sayac++;
                    }
                }
            }
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            UyeBilgiGuncelle();
            UyeBilgiGetir(kullanici);
        }

        private void btnOgrenmeyeBasla_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            btnOgrenmeyeBasla.Visible = false;
            KelimeOgrenmeKaydet(0);
        }

        void GridTamamlananlarDoldur()
        {
            DataTable tablo = new DataTable();
            tablo.Columns.Add("KelimeID", typeof(int));
            tablo.Columns.Add("Kelime", typeof(string));
            tablo.Columns.Add("İngilizce", typeof(string));
            tablo.Columns.Add("Resim", typeof(string));
            tablo.Columns.Add("Tarih", typeof(DateTime));
            tablo.Columns.Add("Kelime Seviyesi", typeof(string));
            foreach (OyunOyna game in oyun1.TamamlananKelimeler)
            {
                tablo.Rows.Add(game.KelimeID, game.Kelime, game.Ingilizce, game.Resim, game.Dt,game.KelimeSeviyesi);
                gridControl2.DataSource = tablo;
            }
            gridView2.OptionsBehavior.Editable = false;
        }

        private void btnGrafikOlustur_Click(object sender, EventArgs e)
        {
            AylıkIstatislik(Convert.ToInt32(cmbYıl.SelectedItem));
        }

        void UyeBilgiGetir(string kullaniciAdi)
        {
            Uye UyeBilgi = new Uye(kullanici);
            UyeBilgi.KisiBilgiGetir(kullanici);
            txtUAd.Text = UyeBilgi.Ad;
            txtUSoyad.Text = UyeBilgi.Soyad;
            txtUMail.Text = UyeBilgi.Mail;
            txtUSifre.Text = UyeBilgi.Sifre;
            mskUTelefon.Text = UyeBilgi.Telefon;
            lblUID.Text = UyeBilgi.KullaniciID;
            txtUNo.Text = UyeBilgi.UyeNo.ToString();
            btnUye.Text= "Sayın Üyemiz, " + UyeBilgi.Ad + " " + UyeBilgi.Soyad;
        }
        void UyeBilgiGuncelle()
        {
            Uye UyeBilgi = new Uye(kullanici);
            UyeBilgi.Mail=txtUMail.Text;
            UyeBilgi.Sifre= txtUSifre.Text;
            UyeBilgi.Telefon= mskUTelefon.Text;
            UyeBilgi.UyeNo = Convert.ToInt32(txtUNo.Text);
            UyeBilgi.KisiBilgiGuncelle();
            MessageBox.Show("Uye Bilgileri Güncellendi...","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void YıllıkIstatistik()
        {
            chartControl1.Series["Yıl"].Points.Clear();
            int yıl2018 = 0,yıl2019=0, yıl2020 = 0, yıl2021 = 0, yıl2022 = 0, yıl2023 = 0, yıl2024 = 0;
            foreach (OyunOyna game in oyun1.TamamlananKelimeler)
            {
                if(game.Dt.Year==2018)
                {
                    yıl2018++;
                }
                else if(game.Dt.Year == 2019)
                {
                    yıl2019++;
                }
                else if (game.Dt.Year == 2020)
                {
                    yıl2020++;
                }
                else if (game.Dt.Year == 2021)
                {
                    yıl2021++;
                }
                else if (game.Dt.Year == 2022)
                {
                    yıl2022++;
                }
                else if (game.Dt.Year == 2023)
                {
                    yıl2023++;
                }
                else if (game.Dt.Year == 2024)
                {
                    yıl2024++;
                }
                else
                {
                    continue;
                }
            }
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2018", yıl2018));
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2019", yıl2019));
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2020", yıl2020));
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2021", yıl2021));
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2022", yıl2022));
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2023", yıl2023));
            chartControl1.Series["Yıl"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("2024", yıl2024));
        }
        void AylıkIstatislik(int Yıl)
        {
            chartControl2.Series["Ay"].Points.Clear();
            int AyOcak = 0, AySubat = 0, AyMart = 0, AyNisan = 0, AyMayis = 0, AyHaziran = 0, AyTemmuz = 0, AyAgustos = 0, AyEylul = 0, AyEkim = 0, AyKasim = 0, AyAralik = 0;
            foreach (OyunOyna game in oyun1.TamamlananKelimeler)
            {
                if(game.Dt.Year == Yıl)
                {
                    if (game.Dt.Month == 01)
                    {
                        AyOcak++;
                    }
                    else if (game.Dt.Month == 02)
                    {
                        AySubat++;
                    }
                    else if (game.Dt.Month == 03)
                    {
                        AyMart++;
                    }
                    else if (game.Dt.Month == 04)
                    {
                        AyNisan++;
                    }
                    else if (game.Dt.Month == 05)
                    {
                        AyMayis++;
                    }
                    else if (game.Dt.Month == 06)
                    {
                        AyHaziran++;
                    }
                    else if (game.Dt.Month == 07)
                    {
                        AyTemmuz++;
                    }
                    else if (game.Dt.Month == 08)
                    {
                        AyAgustos++;
                    }
                    else if (game.Dt.Month == 09)
                    {
                        AyEylul++;
                    }
                    else if (game.Dt.Month == 10)
                    {
                        AyEkim++;
                    }
                    else if (game.Dt.Month == 11)
                    {
                        AyKasim++;
                    }
                    else if (game.Dt.Month == 12)
                    {
                        AyAralik++;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    MessageBox.Show("İstenilen Yıl Bilgisine Ulaşılamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ocak", AyOcak));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Şubat", AySubat));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Mart", AyMart));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Nisan", AyNisan));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Mayıs", AyMayis));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Haziran", AyHaziran));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Temmuz", AyTemmuz));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ağustos", AyAgustos));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Eylül", AyEylul));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ekim", AyEkim));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Kasım", AyKasim));
            chartControl2.Series["Ay"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Aralık", AyAralik));
        }
    }
}
