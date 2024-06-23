namespace winform_4
{
    partial class Form2
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
            this.btn_form1_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form1_git
            // 
            this.btn_form1_git.Location = new System.Drawing.Point(97, 96);
            this.btn_form1_git.Name = "btn_form1_git";
            this.btn_form1_git.Size = new System.Drawing.Size(218, 68);
            this.btn_form1_git.TabIndex = 0;
            this.btn_form1_git.Text = "Form1\'e git";
            this.btn_form1_git.UseVisualStyleBackColor = true;
            this.btn_form1_git.Click += new System.EventHandler(this.btn_form1_git_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 284);
            this.Controls.Add(this.btn_form1_git);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form1_git;
    }
}