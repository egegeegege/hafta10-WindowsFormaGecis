namespace Odev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.lbl_ıslem1 = new System.Windows.Forms.Label();
            this.lbl_ıslem2 = new System.Windows.Forms.Label();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_böl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(414, 91);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(136, 20);
            this.txt_sayi2.TabIndex = 0;
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(205, 91);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(136, 20);
            this.txt_sayi1.TabIndex = 0;
            // 
            // lbl_ıslem1
            // 
            this.lbl_ıslem1.AutoSize = true;
            this.lbl_ıslem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ıslem1.Location = new System.Drawing.Point(157, 94);
            this.lbl_ıslem1.Name = "lbl_ıslem1";
            this.lbl_ıslem1.Size = new System.Drawing.Size(42, 18);
            this.lbl_ıslem1.TabIndex = 1;
            this.lbl_ıslem1.Text = "sayı1";
            // 
            // lbl_ıslem2
            // 
            this.lbl_ıslem2.AutoSize = true;
            this.lbl_ıslem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ıslem2.Location = new System.Drawing.Point(366, 90);
            this.lbl_ıslem2.Name = "lbl_ıslem2";
            this.lbl_ıslem2.Size = new System.Drawing.Size(42, 18);
            this.lbl_ıslem2.TabIndex = 1;
            this.lbl_ıslem2.Text = "sayı2";
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(123, 184);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(109, 37);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "Topla";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Location = new System.Drawing.Point(259, 184);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(109, 37);
            this.btn_cıkar.TabIndex = 2;
            this.btn_cıkar.Text = "Çıkarma";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.btn_cıkar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(392, 184);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(109, 37);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "Çarpma";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_böl
            // 
            this.btn_böl.Location = new System.Drawing.Point(527, 184);
            this.btn_böl.Name = "btn_böl";
            this.btn_böl.Size = new System.Drawing.Size(109, 37);
            this.btn_böl.TabIndex = 2;
            this.btn_böl.Text = "Bölme";
            this.btn_böl.UseVisualStyleBackColor = true;
            this.btn_böl.Click += new System.EventHandler(this.btn_böl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_böl);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_cıkar);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.lbl_ıslem2);
            this.Controls.Add(this.lbl_ıslem1);
            this.Controls.Add(this.txt_sayi1);
            this.Controls.Add(this.txt_sayi2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label lbl_ıslem1;
        private System.Windows.Forms.Label lbl_ıslem2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cıkar;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_böl;
    }
}

