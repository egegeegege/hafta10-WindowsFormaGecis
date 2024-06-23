namespace winform_3
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
            this.btn_dialog = new System.Windows.Forms.Button();
            this.btn_isim_yazdir = new System.Windows.Forms.Button();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_isim_goster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dialog
            // 
            this.btn_dialog.Location = new System.Drawing.Point(111, 75);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(180, 47);
            this.btn_dialog.TabIndex = 0;
            this.btn_dialog.Text = "Tıkla Dialog Göster";
            this.btn_dialog.UseVisualStyleBackColor = true;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // btn_isim_yazdir
            // 
            this.btn_isim_yazdir.Location = new System.Drawing.Point(111, 170);
            this.btn_isim_yazdir.Name = "btn_isim_yazdir";
            this.btn_isim_yazdir.Size = new System.Drawing.Size(180, 47);
            this.btn_isim_yazdir.TabIndex = 0;
            this.btn_isim_yazdir.Text = "Tıkla İsim Yazdır";
            this.btn_isim_yazdir.UseVisualStyleBackColor = true;
            this.btn_isim_yazdir.Click += new System.EventHandler(this.btn_isim_yazdir_Click);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(111, 144);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(180, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // lbl_isim_goster
            // 
            this.lbl_isim_goster.AutoSize = true;
            this.lbl_isim_goster.Location = new System.Drawing.Point(177, 220);
            this.lbl_isim_goster.Name = "lbl_isim_goster";
            this.lbl_isim_goster.Size = new System.Drawing.Size(0, 13);
            this.lbl_isim_goster.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 280);
            this.Controls.Add(this.lbl_isim_goster);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.btn_isim_yazdir);
            this.Controls.Add(this.btn_dialog);
            this.Name = "Form1";
            this.Text = "Örnek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dialog;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_isim_goster;
        private System.Windows.Forms.Button btn_isim_yazdir;
    }
}

