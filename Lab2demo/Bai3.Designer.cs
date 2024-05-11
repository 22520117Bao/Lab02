namespace Lab2demo
{
    partial class Bai3
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
            this.rtxtfile = new System.Windows.Forms.RichTextBox();
            this.btwrite = new System.Windows.Forms.Button();
            this.btread = new System.Windows.Forms.Button();
            this.btex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtfile
            // 
            this.rtxtfile.Location = new System.Drawing.Point(361, 29);
            this.rtxtfile.Name = "rtxtfile";
            this.rtxtfile.Size = new System.Drawing.Size(309, 299);
            this.rtxtfile.TabIndex = 5;
            this.rtxtfile.Text = "";
            // 
            // btwrite
            // 
            this.btwrite.Location = new System.Drawing.Point(55, 238);
            this.btwrite.Name = "btwrite";
            this.btwrite.Size = new System.Drawing.Size(75, 23);
            this.btwrite.TabIndex = 4;
            this.btwrite.Text = "Ghi File ";
            this.btwrite.UseVisualStyleBackColor = true;
            this.btwrite.Click += new System.EventHandler(this.btwrite_Click);
            // 
            // btread
            // 
            this.btread.Location = new System.Drawing.Point(55, 58);
            this.btread.Name = "btread";
            this.btread.Size = new System.Drawing.Size(75, 23);
            this.btread.TabIndex = 3;
            this.btread.Text = "Đọc File ";
            this.btread.UseVisualStyleBackColor = true;
            this.btread.Click += new System.EventHandler(this.btread_Click);
            // 
            // btex
            // 
            this.btex.Location = new System.Drawing.Point(55, 145);
            this.btex.Name = "btex";
            this.btex.Size = new System.Drawing.Size(75, 23);
            this.btex.TabIndex = 6;
            this.btex.Text = "Xu ly ";
            this.btex.UseVisualStyleBackColor = true;
            this.btex.Click += new System.EventHandler(this.btex_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btex);
            this.Controls.Add(this.rtxtfile);
            this.Controls.Add(this.btwrite);
            this.Controls.Add(this.btread);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtfile;
        private System.Windows.Forms.Button btwrite;
        private System.Windows.Forms.Button btread;
        private System.Windows.Forms.Button btex;
    }
}