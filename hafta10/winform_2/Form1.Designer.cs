using System.Drawing;

namespace winform_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_tikla = new System.Windows.Forms.Button();
            this.chck_tv = new System.Windows.Forms.CheckBox();
            this.chck_kitap = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cmb_isimler = new System.Windows.Forms.ComboBox();
            this.lb_sehirler = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_sehirler = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tikla
            // 
            this.btn_tikla.BackColor = System.Drawing.Color.IndianRed;
            this.btn_tikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tikla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tikla.Location = new System.Drawing.Point(50, 42);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Padding = new System.Windows.Forms.Padding(5);
            this.btn_tikla.Size = new System.Drawing.Size(113, 46);
            this.btn_tikla.TabIndex = 0;
            this.btn_tikla.Text = "Button";
            this.btn_tikla.UseVisualStyleBackColor = false;
            // 
            // chck_tv
            // 
            this.chck_tv.AutoSize = true;
            this.chck_tv.Location = new System.Drawing.Point(184, 47);
            this.chck_tv.Name = "chck_tv";
            this.chck_tv.Size = new System.Drawing.Size(40, 17);
            this.chck_tv.TabIndex = 1;
            this.chck_tv.Text = "TV";
            this.chck_tv.UseVisualStyleBackColor = true;
            // 
            // chck_kitap
            // 
            this.chck_kitap.AutoSize = true;
            this.chck_kitap.Location = new System.Drawing.Point(184, 71);
            this.chck_kitap.Name = "chck_kitap";
            this.chck_kitap.Size = new System.Drawing.Size(93, 17);
            this.chck_kitap.TabIndex = 2;
            this.chck_kitap.Text = "Kitap Okumak";
            this.chck_kitap.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(306, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(306, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cmb_isimler
            // 
            this.cmb_isimler.FormattingEnabled = true;
            this.cmb_isimler.Items.AddRange(new object[] {
            "Ali",
            "Ahmet",
            "Ayşe"});
            this.cmb_isimler.Location = new System.Drawing.Point(417, 46);
            this.cmb_isimler.Name = "cmb_isimler";
            this.cmb_isimler.Size = new System.Drawing.Size(121, 21);
            this.cmb_isimler.TabIndex = 4;
            // 
            // lb_sehirler
            // 
            this.lb_sehirler.FormattingEnabled = true;
            this.lb_sehirler.Items.AddRange(new object[] {
            "İstanbul",
            "İzmir",
            "Ankara"});
            this.lb_sehirler.Location = new System.Drawing.Point(559, 31);
            this.lb_sehirler.Name = "lb_sehirler";
            this.lb_sehirler.Size = new System.Drawing.Size(120, 95);
            this.lb_sehirler.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 147);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            // 
            // lbl_sehirler
            // 
            this.lbl_sehirler.AutoSize = true;
            this.lbl_sehirler.Location = new System.Drawing.Point(414, 30);
            this.lbl_sehirler.Name = "lbl_sehirler";
            this.lbl_sehirler.Size = new System.Drawing.Size(36, 13);
            this.lbl_sehirler.TabIndex = 7;
            this.lbl_sehirler.Text = "İsimler";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(265, 153);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(353, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(515, 153);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = this.pictureBox1.Location;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = this.pictureBox1.Size;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 313);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 102);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_sehirler);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_sehirler);
            this.Controls.Add(this.cmb_isimler);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chck_kitap);
            this.Controls.Add(this.chck_tv);
            this.Controls.Add(this.btn_tikla);
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.CheckBox chck_tv;
        private System.Windows.Forms.CheckBox chck_kitap;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cmb_isimler;
        private System.Windows.Forms.ListBox lb_sehirler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_sehirler;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

