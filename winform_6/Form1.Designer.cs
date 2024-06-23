namespace winform_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_diller = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lv_liste = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yaş = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(78, 46);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(128, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yaşınız";
            // 
            // txt_yas
            // 
            this.txt_yas.Location = new System.Drawing.Point(78, 84);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(128, 20);
            this.txt_yas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diller";
            // 
            // cmb_diller
            // 
            this.cmb_diller.FormattingEnabled = true;
            this.cmb_diller.Items.AddRange(new object[] {
            "c#",
            "c++",
            "php",
            "javascript",
            "python"});
            this.cmb_diller.Location = new System.Drawing.Point(78, 122);
            this.cmb_diller.Name = "cmb_diller";
            this.cmb_diller.Size = new System.Drawing.Size(128, 21);
            this.cmb_diller.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ekle.Location = new System.Drawing.Point(42, 195);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(192, 69);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Listeye Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lv_liste
            // 
            this.lv_liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.Yaş,
            this.Dil});
            this.lv_liste.HideSelection = false;
            this.lv_liste.Location = new System.Drawing.Point(256, 46);
            this.lv_liste.Name = "lv_liste";
            this.lv_liste.Size = new System.Drawing.Size(389, 218);
            this.lv_liste.TabIndex = 4;
            this.lv_liste.UseCompatibleStateImageBehavior = false;
            this.lv_liste.View = System.Windows.Forms.View.Details;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 138;
            // 
            // Yaş
            // 
            this.Yaş.Text = "Yaş";
            this.Yaş.Width = 124;
            // 
            // Dil
            // 
            this.Dil.Text = "Dil";
            this.Dil.Width = 104;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 357);
            this.Controls.Add(this.lv_liste);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.cmb_diller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_yas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_diller;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListView lv_liste;
        private System.Windows.Forms.ColumnHeader Yaş;
        private System.Windows.Forms.ColumnHeader Dil;
        private System.Windows.Forms.ColumnHeader Ad;
    }
}

