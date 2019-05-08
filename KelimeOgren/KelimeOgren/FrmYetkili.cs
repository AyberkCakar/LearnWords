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

        private void btnYetkiliEVLA_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void btnYetkiliBilgi_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
        }
        private void btnKelimeGuncelle_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
            GridDoldur();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Kelime kelime = new Kelime();
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picKelimeEkle.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
            kelime.Resim = openFileDialog1.FileName;
        }
        void KelimeEkle()
        {
            Yetkili KelimeEkle = new Yetkili();
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
            Yetkili KelimeGuncelle = new Yetkili();
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
            txtKelime.Text="";
            txtIngilizce.Text = "";
            txtTuru.Text = "";
            txtOrnCumle.Text = "";
            txtTurkceCumle.Text = "";
            txtResim.Text = "";
            picKelimeEkle.ImageLocation = null;
            openFileDialog1.FileName = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KelimeEkle();
            MessageBox.Show("Yeni Kelime Eklenmiştir...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            foreach(Kelime klm in kelime.Kelimeler)
            {
                tablo.Rows.Add(klm.KelimeId,klm.Turkce,klm.Ingilizce,klm.Turu,klm.OrnCumle,klm.TurkceCumle,klm.Resim);
                gridControl1.DataSource = tablo;
            }
            kelime.Kelimeler.Clear();
            gridView1.OptionsBehavior.Editable = false;
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picUpdate.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
            kelime.Resim = openFileDialog1.FileName;
        }

        private void FrmYetkili_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
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
    }
}
