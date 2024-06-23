using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_4
{
    public partial class Form2 : Form
    {
        public string Ozellik { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_form1_git_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Ozellik);
        }
    }
}
