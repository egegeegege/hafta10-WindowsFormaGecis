using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dialog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Ben Dialog penceresiyim");
        }

        private void btn_isim_yazdir_Click(object sender, EventArgs e)
        {
            string isim = txt_isim.Text;
            lbl_isim_goster.Text = isim;
            btn_isim_yazdir.Enabled = false;
        }
    }
}
