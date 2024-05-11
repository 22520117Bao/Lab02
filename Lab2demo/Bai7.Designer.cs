namespace Lab2demo
{
    partial class Bai7
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
            this.picboxkq = new System.Windows.Forms.PictureBox();
            this.tvinput = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxkq)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtfile
            // 
            this.rtxtfile.Location = new System.Drawing.Point(233, 12);
            this.rtxtfile.Name = "rtxtfile";
            this.rtxtfile.Size = new System.Drawing.Size(386, 341);
            this.rtxtfile.TabIndex = 8;
            this.rtxtfile.Text = "";
            // 
            // picboxkq
            // 
            this.picboxkq.Location = new System.Drawing.Point(233, 12);
            this.picboxkq.Name = "picboxkq";
            this.picboxkq.Size = new System.Drawing.Size(386, 298);
            this.picboxkq.TabIndex = 7;
            this.picboxkq.TabStop = false;
            // 
            // tvinput
            // 
            this.tvinput.Location = new System.Drawing.Point(21, 12);
            this.tvinput.Name = "tvinput";
            this.tvinput.Size = new System.Drawing.Size(188, 319);
            this.tvinput.TabIndex = 6;
            this.tvinput.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.tvinput.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tvinput.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.tvinput.DoubleClick += new System.EventHandler(this.tvinput_DoubleClick);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtfile);
            this.Controls.Add(this.picboxkq);
            this.Controls.Add(this.tvinput);
            this.Name = "Bai7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxkq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtfile;
        private System.Windows.Forms.PictureBox picboxkq;
        private System.Windows.Forms.TreeView tvinput;
    }
}