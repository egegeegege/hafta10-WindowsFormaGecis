﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_form2_git_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Ozellik = "Merhaba";
            form2.Show();
            this.Hide();
        }
    }
}
