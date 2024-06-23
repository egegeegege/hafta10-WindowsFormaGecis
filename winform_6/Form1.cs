using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //lv_liste.Items.Add(txt_ad.Text + " " + txt_yas.Text + " " + cmb_diller.Text);
            //lv_liste.Columns[0].Text = txt_ad.Text;
            //lv_liste.Columns[1].Text = txt_yas.Text;
            //lv_liste.Columns[2].Text = cmb_diller.Text;

            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(txt_ad.Text);
            lvi.SubItems.Add(txt_yas.Text);
            lvi.SubItems.Add(cmb_diller.Text);

            lv_liste.Items.Add(lvi);
        }
    }
}
