using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2demo
{
    public partial class TongDuyet : Form
    {
        public TongDuyet()
        {
            InitializeComponent();
        }

        private void btbai1_Click(object sender, EventArgs e)
        {
            Form f1 = new Bai1();
            f1.Show();
        }

        private void btbai2_Click(object sender, EventArgs e)
        {
            Form f2 = new Bai2();
            f2.Show();
        }

        private void btbai3_Click(object sender, EventArgs e)
        {
            Form f3 = new Bai3();
            f3.Show();
        }

        private void btbai4_Click(object sender, EventArgs e)
        {
            Form f4 = new Bai4();
            f4.Show();
        }

        private void btbai5_Click(object sender, EventArgs e)
        {
            Form f5 = new Bai5();
            f5.Show();
        }

        private void btbai6_Click(object sender, EventArgs e)
        {
            Form f6 = new Bai6();
            f6.Show();
        }

        private void btbai7_Click(object sender, EventArgs e)
        {
            Form f7 = new Bai7();
            f7.Show();
        }
    }
}
