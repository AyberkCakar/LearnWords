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
    public partial class FrmYetkili : Form
    {
        public FrmYetkili()
        {
            InitializeComponent();
        }
        public string kullanici;
        private void btnYetkiliEVLA_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }
        private void btnYetkiliBilgi_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex =2;
            YetkiliBilgiGetir(kullanici);
        }
        private void btnKelimeGuncelle_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
            GridDoldur();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Kelime kelime = new Kelime();
        private void btnYeniResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //Resim seçme penceresini aç
            picKelimeEkle.ImageLocation = openFileDialog1.FileName; //Seçilen resmi görüntüle
            txtResim.Text = openFileDialog1.FileName;  //Seçilen resmin adresini aktar
            kelime.Resim = openFileDialog1.FileName; //Seçilen resmin adresini aktar
        }
        void KelimeEkle()
        {
            Yetkili KelimeEkle = new Yetkili(kullanici);
            Kelime word = new Kelime();
            word.Turkce = txtKelime.Text;
            word.Ingilizce = txtIngilizce.Text;
            word.Turu = txtTuru.Text;
            word.OrnCumle = txtOrnCumle.Text;
            word.TurkceCumle = txtTurkceCumle.Text;
            word.Resim = txtResim.Text;
            KelimeEkle.KelimeEkle(word);
        }
        void KelimeGuncelle()
        {
            Yetkili KelimeGuncelle = new Yetkili(kullanici);
            Kelime word = new Kelime();
            word.KelimeId = Convert.ToInt32(txtUpKelimeID.Text);
            word.Turkce = txtUpKelime.Text;
            word.Ingilizce = txtUpIngilizce.Text;
            word.Turu = txtUpTur.Text;
            word.OrnCumle = txtUpOrnCumle.Text;
            word.TurkceCumle = txtUpTurkCumle.Text;
            word.Resim = txtUpResim.Text;
            KelimeGuncelle.KelimeGuncelle(word);
        }
        void KelimeGuncelleTemizle()
        {
            txtUpKelime.Text = "";
            txtUpKelime.Text = "";
            txtUpIngilizce.Text = "";
            txtUpTur.Text = "";
            txtUpOrnCumle.Text = "";
            txtUpTurkCumle.Text = "";
            txtUpKelimeID.Text = "";
            picUpdate.ImageLocation = null;
            openFileDialog1.FileName = null;
        }
        void KelimeEkleTemizle()
        {
            txtKelime.Text = "";
            txtIngilizce.Text = "";
            txtTuru.Text = "";
            txtOrnCumle.Text = "";
            txtTurkceCumle.Text = "";
            txtResim.Text = "";
            picKelimeEkle.ImageLocation = null;
            openFileDialog1.FileName = null;
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            KelimeEkle();
            MessageBox.Show("Yeni Kelime Eklenmiştir...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KelimeEkleTemizle();
        }
        void GridDoldur()
        {
            kelime.YetkiliKelime();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("KelimeID", typeof(int));
            tablo.Columns.Add("Kelime", typeof(string));
            tablo.Columns.Add("İngilizce", typeof(string));
            tablo.Columns.Add("Türü", typeof(string));
            tablo.Columns.Add("Örnek Cümle", typeof(string));
            tablo.Columns.Add("Cümle Türkçe", typeof(string));
            tablo.Columns.Add("Resim", typeof(string));
            foreach (Kelime word in kelime.Kelimeler)
            {
                tablo.Rows.Add(word.KelimeId, word.Turkce, word.Ingilizce, word.Turu, word.OrnCumle, word.TurkceCumle, word.Resim);
                gridControl1.DataSource = tablo;
            }
            kelime.Kelimeler.Clear();
            gridView1.OptionsBehavior.Editable = false;
        }


        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();  //Resim seçme penceresini aç
            picUpdate.ImageLocation = openFileDialog1.FileName;  //Seçilen resmi görüntüle
            txtUpResim.Text = openFileDialog1.FileName;  //Seçilen resmin adresini aktar
            kelime.Resim = openFileDialog1.FileName; //Seçilen resmin adresini aktar
        }
        private void FrmYetkili_Load(object sender, EventArgs e)
        {
            YetkiliBilgiGetir(kullanici);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {                                                                   //Gridden seçilen satırı gerekli yerlere doldur.(Kelime bilgilerini göster)
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtUpKelimeID.Text = Convert.ToInt32(dr[0]).ToString();
            txtUpKelime.Text = dr[1].ToString();
            txtUpIngilizce.Text = dr[2].ToString();
            txtUpTur.Text = dr[3].ToString();
            txtUpOrnCumle.Text = dr[4].ToString();
            txtUpTurkCumle.Text = dr[5].ToString();
            txtUpResim.Text = dr[6].ToString();
            picUpdate.ImageLocation = dr[6].ToString();
        }

        private void btnWordUpdate_Click(object sender, EventArgs e)
        {
            KelimeGuncelle();
            MessageBox.Show("Kelime Güncellenmiştir...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KelimeGuncelleTemizle();
        }
        void YetkiliBilgiGetir(string kullaniciAdi)
        {
            Yetkili yetkiliBilgi = new Yetkili(kullaniciAdi);
            yetkiliBilgi.KisiBilgiGetir(kullaniciAdi);
            txtYAd.Text = yetkiliBilgi.Ad;
            txtYSoyad.Text = yetkiliBilgi.Soyad;
            txtYMail.Text = yetkiliBilgi.Mail;
            txtYSifre.Text = yetkiliBilgi.Sifre;
            mskYTelefon.Text = yetkiliBilgi.Telefon;
            lblYID.Text = yetkiliBilgi.KullaniciID;
            txtYetkiliNo.Text = yetkiliBilgi.YetkiliNo.ToString();
            btnYetkili.Text = "Sayın "+yetkiliBilgi.Yetki +" , "+yetkiliBilgi.Ad + " " + yetkiliBilgi.Soyad;
        }
        void YetkiliBilgiGuncelle()
        {
            Yetkili yetkiliBilgi = new Yetkili(kullanici);
            yetkiliBilgi.Mail = txtYMail.Text;
            yetkiliBilgi.Sifre = txtYSifre.Text;
            yetkiliBilgi.Telefon = mskYTelefon.Text;
            yetkiliBilgi.YetkiliNo = Convert.ToInt32(txtYetkiliNo.Text);
            yetkiliBilgi.KisiBilgiGuncelle();
            MessageBox.Show("Bilgileriniz Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYetkiliGuncelle_Click(object sender, EventArgs e)
        {
            YetkiliBilgiGuncelle();
            YetkiliBilgiGetir(kullanici);
        }
        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtYSifre.UseSystemPasswordChar == false)
            {
                txtYSifre.UseSystemPasswordChar = true;
            }
            else if (txtYSifre.UseSystemPasswordChar == true)
            {
                txtYSifre.UseSystemPasswordChar = false;
            }
        }
    }
}
