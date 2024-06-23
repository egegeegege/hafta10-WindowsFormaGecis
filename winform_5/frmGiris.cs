using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_5
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(txt_kad.Text == "" || txt_parola.Text == "")
            {
                MessageBox.Show("Lütfen Boş değer girmeyiniz");
            }
            else
            {
                if(txt_kad.Text == "admin" && txt_parola.Text == "12345")
                {
                    frmAnasayfa frmAnasayfa = new frmAnasayfa();
                    frmAnasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada parolanız yanlış");
                }
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
