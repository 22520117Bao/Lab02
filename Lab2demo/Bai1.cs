using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2demo
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sread = new StreamReader(fs);
            string str = sread.ReadToEnd();
            rtxtfile.Text = str.ToString();
            fs.Close();
            Console.ReadLine();
        }

        private void btwrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Create);
            StreamWriter swrite = new StreamWriter(fs);
            rtxtfile.Text = rtxtfile.Text.ToUpper();
            swrite.Write(rtxtfile.Text);
            swrite.Flush(); //  se chuyen moi thu trong Luong ra ngoai tep // Dieu nay co the thuc hien giua qua trinh su dung Luong va ban co the tiep tuc viet
            fs.Close(); // Dieu nay
        }
    }
}
