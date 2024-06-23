namespace winform_4
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
            this.btn_form2_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form2_git
            // 
            this.btn_form2_git.Location = new System.Drawing.Point(124, 76);
            this.btn_form2_git.Name = "btn_form2_git";
            this.btn_form2_git.Size = new System.Drawing.Size(156, 67);
            this.btn_form2_git.TabIndex = 0;
            this.btn_form2_git.Text = "Form2\'ye Git";
            this.btn_form2_git.UseVisualStyleBackColor = true;
            this.btn_form2_git.Click += new System.EventHandler(this.btn_form2_git_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 272);
            this.Controls.Add(this.btn_form2_git);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form2_git;
    }
}

