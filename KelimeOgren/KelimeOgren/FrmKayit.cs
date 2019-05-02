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
    }
}
