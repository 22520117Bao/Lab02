namespace Lab2demo
{
    partial class Bai1
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
            this.btread = new System.Windows.Forms.Button();
            this.btwrite = new System.Windows.Forms.Button();
            this.rtxtfile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btread
            // 
            this.btread.Location = new System.Drawing.Point(63, 50);
            this.btread.Name = "btread";
            this.btread.Size = new System.Drawing.Size(75, 23);
            this.btread.TabIndex = 0;
            this.btread.Text = "Đọc File ";
            this.btread.UseVisualStyleBackColor = true;
            this.btread.Click += new System.EventHandler(this.button1_Click);
            // 
            // btwrite
            // 
            this.btwrite.Location = new System.Drawing.Point(63, 160);
            this.btwrite.Name = "btwrite";
            this.btwrite.Size = new System.Drawing.Size(75, 23);
            this.btwrite.TabIndex = 1;
            this.btwrite.Text = "Ghi File ";
            this.btwrite.UseVisualStyleBackColor = true;
            this.btwrite.Click += new System.EventHandler(this.btwrite_Click);
            // 
            // rtxtfile
            // 
            this.rtxtfile.Location = new System.Drawing.Point(369, 21);
            this.rtxtfile.Name = "rtxtfile";
            this.rtxtfile.Size = new System.Drawing.Size(309, 299);
            this.rtxtfile.TabIndex = 2;
            this.rtxtfile.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtfile);
            this.Controls.Add(this.btwrite);
            this.Controls.Add(this.btread);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btread;
        private System.Windows.Forms.Button btwrite;
        private System.Windows.Forms.RichTextBox rtxtfile;
    }
}