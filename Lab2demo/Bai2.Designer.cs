namespace Lab2demo
{
    partial class Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txturl = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtcharcount = new System.Windows.Forms.TextBox();
            this.rtxtread = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtchcount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btread
            // 
            this.btread.Location = new System.Drawing.Point(29, 12);
            this.btread.Name = "btread";
            this.btread.Size = new System.Drawing.Size(206, 23);
            this.btread.TabIndex = 0;
            this.btread.Text = "Read from file";
            this.btread.UseVisualStyleBackColor = true;
            this.btread.Click += new System.EventHandler(this.btread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Word count";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(29, 338);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(206, 23);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(108, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(151, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(108, 107);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(151, 20);
            this.txtsize.TabIndex = 8;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(108, 163);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(151, 20);
            this.txturl.TabIndex = 9;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(119, 208);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(151, 20);
            this.txtcount.TabIndex = 10;
            // 
            // txtcharcount
            // 
            this.txtcharcount.Location = new System.Drawing.Point(119, 265);
            this.txtcharcount.Name = "txtcharcount";
            this.txtcharcount.Size = new System.Drawing.Size(161, 20);
            this.txtcharcount.TabIndex = 11;
            // 
            // rtxtread
            // 
            this.rtxtread.Location = new System.Drawing.Point(337, 14);
            this.rtxtread.Name = "rtxtread";
            this.rtxtread.Size = new System.Drawing.Size(451, 271);
            this.rtxtread.TabIndex = 12;
            this.rtxtread.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Character count";
            // 
            // txtchcount
            // 
            this.txtchcount.Location = new System.Drawing.Point(119, 303);
            this.txtchcount.Name = "txtchcount";
            this.txtchcount.Size = new System.Drawing.Size(151, 20);
            this.txtchcount.TabIndex = 14;
            this.txtchcount.TextChanged += new System.EventHandler(this.txtchcount_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtchcount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtread);
            this.Controls.Add(this.txtcharcount);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btread);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtcharcount;
        private System.Windows.Forms.RichTextBox rtxtread;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtchcount;
    }
}