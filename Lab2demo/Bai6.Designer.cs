namespace Lab2demo
{
    partial class Bai6
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            ""}, -1);
            this.lstnd = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuyenHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgridkq = new System.Windows.Forms.DataGridView();
            this.dtgridfood = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btdanhsachnguoi = new System.Windows.Forms.Button();
            this.btNhapNguoi = new System.Windows.Forms.Button();
            this.txtquyenhan = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.txtidnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhapmon = new System.Windows.Forms.Button();
            this.btxuatmon = new System.Windows.Forms.Button();
            this.btchonfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpicture = new System.Windows.Forms.TextBox();
            this.txtnamefood = new System.Windows.Forms.TextBox();
            this.txtmonan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btrandomselect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridkq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridfood)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstnd
            // 
            this.lstnd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.HoTen,
            this.QuyenHan});
            this.lstnd.GridLines = true;
            this.lstnd.HideSelection = false;
            this.lstnd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstnd.Location = new System.Drawing.Point(362, 6);
            this.lstnd.Name = "lstnd";
            this.lstnd.Size = new System.Drawing.Size(342, 145);
            this.lstnd.TabIndex = 9;
            this.lstnd.UseCompatibleStateImageBehavior = false;
            this.lstnd.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // HoTen
            // 
            this.HoTen.Text = "HovaTen";
            this.HoTen.Width = 100;
            // 
            // QuyenHan
            // 
            this.QuyenHan.Text = "QuyenHan";
            this.QuyenHan.Width = 100;
            // 
            // dtgridkq
            // 
            this.dtgridkq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridkq.Location = new System.Drawing.Point(315, 361);
            this.dtgridkq.Name = "dtgridkq";
            this.dtgridkq.Size = new System.Drawing.Size(418, 137);
            this.dtgridkq.TabIndex = 8;
            // 
            // dtgridfood
            // 
            this.dtgridfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridfood.Location = new System.Drawing.Point(479, 157);
            this.dtgridfood.Name = "dtgridfood";
            this.dtgridfood.Size = new System.Drawing.Size(309, 198);
            this.dtgridfood.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btdanhsachnguoi);
            this.groupBox2.Controls.Add(this.btNhapNguoi);
            this.groupBox2.Controls.Add(this.txtquyenhan);
            this.groupBox2.Controls.Add(this.txthovaten);
            this.groupBox2.Controls.Add(this.txtidnd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(30, -20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 182);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nguoi Nhap";
            // 
            // btdanhsachnguoi
            // 
            this.btdanhsachnguoi.Location = new System.Drawing.Point(161, 151);
            this.btdanhsachnguoi.Name = "btdanhsachnguoi";
            this.btdanhsachnguoi.Size = new System.Drawing.Size(75, 23);
            this.btdanhsachnguoi.TabIndex = 12;
            this.btdanhsachnguoi.Text = "xuat nguoi";
            this.btdanhsachnguoi.UseVisualStyleBackColor = true;
            this.btdanhsachnguoi.Click += new System.EventHandler(this.btdanhsachnguoi_Click);
            // 
            // btNhapNguoi
            // 
            this.btNhapNguoi.Location = new System.Drawing.Point(39, 151);
            this.btNhapNguoi.Name = "btNhapNguoi";
            this.btNhapNguoi.Size = new System.Drawing.Size(75, 23);
            this.btNhapNguoi.TabIndex = 11;
            this.btNhapNguoi.Text = "Nhap nguoi";
            this.btNhapNguoi.UseVisualStyleBackColor = true;
            this.btNhapNguoi.Click += new System.EventHandler(this.btNhapNguoi_Click);
            // 
            // txtquyenhan
            // 
            this.txtquyenhan.Location = new System.Drawing.Point(72, 107);
            this.txtquyenhan.Name = "txtquyenhan";
            this.txtquyenhan.Size = new System.Drawing.Size(193, 20);
            this.txtquyenhan.TabIndex = 10;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(65, 70);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(200, 20);
            this.txthovaten.TabIndex = 9;
            // 
            // txtidnd
            // 
            this.txtidnd.Location = new System.Drawing.Point(49, 26);
            this.txtidnd.Name = "txtidnd";
            this.txtidnd.Size = new System.Drawing.Size(216, 20);
            this.txtidnd.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quyen han";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HovaTen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnhapmon);
            this.groupBox1.Controls.Add(this.btxuatmon);
            this.groupBox1.Controls.Add(this.btchonfile);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtpicture);
            this.groupBox1.Controls.Add(this.txtnamefood);
            this.groupBox1.Controls.Add(this.txtmonan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mon an";
            // 
            // btnhapmon
            // 
            this.btnhapmon.Location = new System.Drawing.Point(47, 124);
            this.btnhapmon.Name = "btnhapmon";
            this.btnhapmon.Size = new System.Drawing.Size(75, 23);
            this.btnhapmon.TabIndex = 5;
            this.btnhapmon.Text = "Nhap mon";
            this.btnhapmon.UseVisualStyleBackColor = true;
            this.btnhapmon.Click += new System.EventHandler(this.btnhapmon_Click);
            // 
            // btxuatmon
            // 
            this.btxuatmon.Location = new System.Drawing.Point(171, 124);
            this.btxuatmon.Name = "btxuatmon";
            this.btxuatmon.Size = new System.Drawing.Size(75, 23);
            this.btxuatmon.TabIndex = 6;
            this.btxuatmon.Text = "Xuat mon";
            this.btxuatmon.UseVisualStyleBackColor = true;
            this.btxuatmon.Click += new System.EventHandler(this.btxuatmon_Click);
            // 
            // btchonfile
            // 
            this.btchonfile.Location = new System.Drawing.Point(192, 69);
            this.btchonfile.Name = "btchonfile";
            this.btchonfile.Size = new System.Drawing.Size(75, 23);
            this.btchonfile.TabIndex = 8;
            this.btchonfile.Text = "chon file";
            this.btchonfile.UseVisualStyleBackColor = true;
            this.btchonfile.Click += new System.EventHandler(this.btchonfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 172);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(49, 98);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(216, 20);
            this.txtid.TabIndex = 7;
            // 
            // txtpicture
            // 
            this.txtpicture.Location = new System.Drawing.Point(62, 72);
            this.txtpicture.Name = "txtpicture";
            this.txtpicture.Size = new System.Drawing.Size(124, 20);
            this.txtpicture.TabIndex = 6;
            // 
            // txtnamefood
            // 
            this.txtnamefood.Location = new System.Drawing.Point(76, 46);
            this.txtnamefood.Name = "txtnamefood";
            this.txtnamefood.Size = new System.Drawing.Size(187, 20);
            this.txtnamefood.TabIndex = 5;
            // 
            // txtmonan
            // 
            this.txtmonan.Location = new System.Drawing.Point(73, 20);
            this.txtmonan.Name = "txtmonan";
            this.txtmonan.Size = new System.Drawing.Size(192, 20);
            this.txtmonan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hinh anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten mon an";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma mon an";
            // 
            // btrandomselect
            // 
            this.btrandomselect.Location = new System.Drawing.Point(74, 396);
            this.btrandomselect.Name = "btrandomselect";
            this.btrandomselect.Size = new System.Drawing.Size(135, 43);
            this.btrandomselect.TabIndex = 10;
            this.btrandomselect.Text = "Mon An hom nay la";
            this.btrandomselect.UseVisualStyleBackColor = true;
            this.btrandomselect.Click += new System.EventHandler(this.btrandomselect_Click);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btrandomselect);
            this.Controls.Add(this.lstnd);
            this.Controls.Add(this.dtgridkq);
            this.Controls.Add(this.dtgridfood);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai6";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridkq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridfood)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstnd;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader QuyenHan;
        private System.Windows.Forms.DataGridView dtgridkq;
        private System.Windows.Forms.DataGridView dtgridfood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btdanhsachnguoi;
        private System.Windows.Forms.Button btNhapNguoi;
        private System.Windows.Forms.TextBox txtquyenhan;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.TextBox txtidnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhapmon;
        private System.Windows.Forms.Button btxuatmon;
        private System.Windows.Forms.Button btchonfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpicture;
        private System.Windows.Forms.TextBox txtnamefood;
        private System.Windows.Forms.TextBox txtmonan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btrandomselect;
    }
}