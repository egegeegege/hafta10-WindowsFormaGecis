using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_sayi1.Text == "" || txt_sayi2.Text == "")
                {
                    MessageBox.Show("lütfen boş karakter girmeyiniz");
                }
                else
                {
                    int sayi1 = int.Parse(txt_sayi1.Text);
                    int sayi2 = int.Parse(txt_sayi2.Text);
                    int sonuc = sayi2 + sayi1;

                    MessageBox.Show($"toplama işleminde Çıkan Sonuç: {sonuc}");
                }
                

            }
            catch
            {
                MessageBox.Show("girdiğiniz karakterler string karakter içermektedir");
            }

        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            if (txt_sayi1.Text == "" || txt_sayi2.Text == "")
            {
                MessageBox.Show("lütfen boş karakter girmeyiniz");
            }
            else
            {
                int sayi1 = int.Parse(txt_sayi1.Text);
                int sayi2 = int.Parse(txt_sayi2.Text);
                int sonuc = sayi2 - sayi1;

                MessageBox.Show($"Çıkarma işleminde Çıkan Sonuç: {sonuc}");
            }
            
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            if (txt_sayi1.Text == "" || txt_sayi2.Text == "")
            {
                MessageBox.Show("lütfen boş karakter girmeyiniz");
            }
            else
            {
                int sayi1 = int.Parse(txt_sayi1.Text);
                int sayi2 = int.Parse(txt_sayi2.Text);
                int sonuc = sayi2 * sayi1;

                MessageBox.Show($"Çarpma işleminde Çıkan Sonuç: {sonuc}");
            }
           
        }

        private void btn_böl_Click(object sender, EventArgs e)
        {
            if (txt_sayi1.Text == "" || txt_sayi2.Text == "")
            {
                MessageBox.Show("lütfen boş karakter girmeyiniz");
            }
            else
            {
                int sayi1 = int.Parse(txt_sayi1.Text);
                int sayi2 = int.Parse(txt_sayi2.Text);
                int sonuc = sayi2 / sayi1;

                MessageBox.Show($"Bölme işleminde Çıkan Sonuç: {sonuc}");
            }
            
        }
    }
}
