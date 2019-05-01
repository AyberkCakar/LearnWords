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
            if (textBox1.Text == "Kullanıcı ID")
                textBox1.Text = "";
            if (textBox2.Text == "")
            {
                textBox2.Text = "Sifre";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="Sifre")
                textBox2.Text = "";
            if(textBox1.Text=="")
            {
                textBox1.Text = "Kullanıcı ID";
                
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
