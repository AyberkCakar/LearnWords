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
        private void Form1_Load(object sender, EventArgs e)
        {

            kelime.KelimeOgren();
            KelimeGetir(0);
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
    }
}
