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
        public string kullanici; // Giris Bilgileri için kullanıcı id tutuyoruz.
        Kelime kelime = new Kelime();
        OyunOyna Oyun = new OyunOyna();
        private void Form1_Load(object sender, EventArgs e)
        {
            Uye UyeOyun = new Uye(kullanici);
            kelime.TumKelime(UyeOyun); //Form yüklendiğinde Kontrol Oyunundaki şıklar için bütün kelimeleri TümKelimeler List'ine çekiyoruz.
            kelime.KelimeOgren(UyeOyun); // Form Yüklendiğinde üyenin öğrenmediği kelimeler List'e Yükleniyor.
            KelimeGetir(0); // Form yüklenince ilk kelimeyi gerekli yerlere doldur.
            UyeOyun.OyunBilgileriniGetir(Oyun); //Üyenin öğrendiği kelimeleri getir.
            UyeBilgiGetir(kullanici); //Form Yüklendiğinde üyenin bilgilerini getir.
        }
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
            GridTamamlananlarDoldur();  //Tamamladığım kelimeleri ( seviye 5) Gridde doldur.
            YıllıkIstatistik(); 
            SonHaftaIstatislik();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
            UyeBilgiGetir(kullanici); //Üyenin Bilgilerini Butona tıklayınca Getir (Her seferinde update (yenileme) sağlam
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int kelimeKontrol = 0, MaxCount;

        void KelimeGetir(int say)
        {
            Kelime kelime = new Kelime();
            kelime= this.kelime.UyeKelimeOgren(say);
            MaxCount = this.kelime.TumKelimeler.Count();
            lblTur.Text =kelime.Turu;
            lblKelime.Text = kelime.Turkce;
            lblIng.Text = kelime.Ingilizce;
            lblOrn.Text = kelime.OrnCumle;
            lblOrnTurk.Text = kelime.TurkceCumle;
            pictureBox1.ImageLocation = kelime.Resim;          
        }
        void KelimeOgrenmeKaydet(int say)
        {
            Uye UyeOyun = new Uye(kullanici);
            DateTime dt = DateTime.Today;
            Kelime kelime = new Kelime();
            kelime = this.kelime.UyeKelimeOgren(say);
            Oyun.KelimeID = kelime.KelimeId;
            Oyun.Kelime = kelime.Turkce;
            Oyun.Ingilizce = kelime.Ingilizce;
            Oyun.Resim = kelime.Resim;
            Oyun.KullanıcıID = UyeOyun.kullaniciAdi;
            Oyun.Date = dt;
            Oyun.KelimeSeviyesi = 1;
            UyeOyun.OyunBilgisiGir(Oyun);
        }

        private void btnOgrenNext_Click(object sender, EventArgs e)
        {
            kelimeKontrol++;
            if (kelimeKontrol >= kelime.Kelimeler.Count()  || kelimeKontrol == kelime.Kelimeler.Count() )
                kelimeKontrol = kelime.Kelimeler.Count() - 1;
            else
            {
                KelimeGetir(kelimeKontrol);
                KelimeOgrenmeKaydet(kelimeKontrol);
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
        int sayi, kontrol = 0;
        void KelimeOyunu()
        {

            if (Oyun.Game.Count < kontrol)
            {
                btnKelimeNext.Enabled = false;
                panel1.Visible = true;
                lblSon.Visible = true;
            }
            else
            {
                OyunOyna GameBasla = new OyunOyna();
                GameBasla = this.Oyun.Oyun(kontrol);
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
            Uye UyeOyun = new Uye(kullanici);
            DateTime dt = DateTime.Today;
            Oyun.KelimeID = KelimeID;
            Oyun.KelimeSeviyesi = Kademe + 1;
            Oyun.Date = Convert.ToDateTime(dt);
            Oyun.KullanıcıID = UyeOyun.kullaniciAdi;
            UyeOyun.OyunBilgileriniUpdate(Oyun);
        }
        void KelimeKontrolUpdateFalse(int KelimeID, int Kademe)
        {
            Uye UyeOyun = new Uye(kullanici);
            DateTime dt = DateTime.Today;
            Oyun.KelimeID = KelimeID;
            Oyun.KelimeSeviyesi = 1;
            Oyun.Date = Convert.ToDateTime(dt);
            Oyun.KullanıcıID = UyeOyun.kullaniciAdi;
            UyeOyun.OyunBilgileriniUpdate(Oyun);
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
            Kelime word = this.kelime;
            int randomm, sayac=0;
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                randomm = random.Next(0, MaxCount + 1);
                foreach (Kelime klm in word.TumKelimeler)
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
            foreach (OyunOyna game in Oyun.TamamlananKelimeler)
            {
                tablo.Rows.Add(game.KelimeID, game.Kelime, game.Ingilizce, game.Resim, game.Date,game.KelimeSeviyesi);
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
            foreach (OyunOyna game in Oyun.TamamlananKelimeler)
            {
                if(game.Date.Year==2018)
                {
                    yıl2018++;
                }
                else if(game.Date.Year == 2019)
                {
                    yıl2019++;
                }
                else if (game.Date.Year == 2020)
                {
                    yıl2020++;
                }
                else if (game.Date.Year == 2021)
                {
                    yıl2021++;
                }
                else if (game.Date.Year == 2022)
                {
                    yıl2022++;
                }
                else if (game.Date.Year == 2023)
                {
                    yıl2023++;
                }
                else if (game.Date.Year == 2024)
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
            foreach (OyunOyna game in Oyun.TamamlananKelimeler)
            {
                if(game.Date.Year == Yıl)
                {
                    if (game.Date.Month == 01)
                    {
                        AyOcak++;
                    }
                    else if (game.Date.Month == 02)
                    {
                        AySubat++;
                    }
                    else if (game.Date.Month == 03)
                    {
                        AyMart++;
                    }
                    else if (game.Date.Month == 04)
                    {
                        AyNisan++;
                    }
                    else if (game.Date.Month == 05)
                    {
                        AyMayis++;
                    }
                    else if (game.Date.Month == 06)
                    {
                        AyHaziran++;
                    }
                    else if (game.Date.Month == 07)
                    {
                        AyTemmuz++;
                    }
                    else if (game.Date.Month == 08)
                    {
                        AyAgustos++;
                    }
                    else if (game.Date.Month == 09)
                    {
                        AyEylul++;
                    }
                    else if (game.Date.Month == 10)
                    {
                        AyEkim++;
                    }
                    else if (game.Date.Month == 11)
                    {
                        AyKasim++;
                    }
                    else if (game.Date.Month == 12)
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
                    continue;
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
        void SonHaftaIstatislik()
        {
            chartControl3.Series["Gün"].Points.Clear();
            int GunPazartesi = 0, GunSali = 0, GunCarsamba = 0, GunPersembe = 0, GunCuma = 0, GunCumartesi = 0, GunPazar = 0;
            foreach (OyunOyna game in Oyun.TamamlananKelimeler)
            {
                if (DayOfWeek.Monday == game.Date.DayOfWeek)
                {
                    GunPazartesi++;
                }
                else if (DayOfWeek.Tuesday == game.Date.DayOfWeek)
                {
                    GunSali++;
                }
                else if (DayOfWeek.Wednesday == game.Date.DayOfWeek)
                {
                    GunCarsamba++;
                }
                else if (DayOfWeek.Thursday == game.Date.DayOfWeek)
                {
                    GunPersembe++;
                }
                else if (DayOfWeek.Friday == game.Date.DayOfWeek)
                {
                    GunCuma++;
                }
                else if (DayOfWeek.Saturday==game.Date.DayOfWeek)
                {
                    GunCumartesi++;
                }
                else if (DayOfWeek.Sunday == game.Date.DayOfWeek)
                {
                    GunPazar++;
                }
                else
                {
                    continue;
                }
            }
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Pazartesi", GunPazartesi));
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Salı", GunSali));
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Çarşamba", GunCarsamba));
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Perşembe", GunPersembe));
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Cuma", GunCuma));
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Cumartesi", GunCumartesi));
            chartControl3.Series["Gün"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Pazar", GunPazar));
        }
    }
}
