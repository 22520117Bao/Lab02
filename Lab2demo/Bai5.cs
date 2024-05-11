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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btwrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Create);

            StreamWriter swrite = new StreamWriter(fs);


            swrite.Write(rtxtfile.Text);
            swrite.Flush(); //  se chuyen moi thu trong Luong ra ngoai tep // Dieu nay co the thuc hien giua qua trinh su dung Luong va ban co the tiep tuc viet
            fs.Close(); // Dieu nay
            rtxtfile.Text = "";
        }
        static string sp = "";
        private void btread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sread = new StreamReader(fs);
            string str = sread.ReadToEnd();

            rtxtfile.Text = str;
            sp = ofd.FileName;
            fs.Close();
            Console.ReadLine();
        }
        static int[] countban = new int[4];
        static int[] countconlai = new int[4];
        static long[] doanhthu = new long[4];
        static string[] tenphim = new string[4] { "Đào, phở và piano", "Mai", "Tarot", "Gặp lại chị bầu" };
        static float[] tile = new float[4];
        static string[] xephang = new string[4];
        static int countl = 0;

        private void btadd_Click(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            string c = "";

            string[] ve = new string[15];
            int i = 0;
            a = txtname.Text;
            b = txtfilm.Text;
            c = txtkind.Text;

            foreach (string item in cklstseat.CheckedItems)
            {

                ve[i] = item;
                i++;

            }
            string str_a = "";
            for (int k = 0; k < i; k++)
            {
                str_a += ve[k];
                cklstseat.Items.Remove(ve[k]);
            }
            countl++;
            rtxtfile.Text += a + "\n"
                            + b + "\n"
                            + c + "\n"
                            + str_a + "\n\n";
        }
        static int a1 = 45;
        static int a2 = 30;
        static int a3 = 15;
        static int a4 = 15;

        private void btxuly_Click(object sender, EventArgs e)
        {
            string[] khachhang = File.ReadAllLines(sp);
            string c = "";

            int dem = -1;

            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;

            float b1 = 0;
            float b2 = 0;
            float b3 = 0;
            float b4 = 0;
            long d1 = 0;
            long d2 = 0;
            long d3 = 0;
            long d4 = 0;
            string str_d = "";
            string str_e = "";
            for (int i = 0; i < khachhang.Length; i++)
            {
                //MessageBox.Show("da vao vong for", "Thong bao");
                c = khachhang[i];
                //MessageBox.Show(c, "ta co c la: ");

                dem++;

                if (c == "Đào, phở và piano")
                {
                    str_d = c;




                }
                if (c == "Mai")
                {
                    str_d = c;
                    //MessageBox.Show(str_d, "phim duoc chon la");


                }
                if (c == "Tarot")
                {
                    str_d = c;


                }
                if (c == "Gặp lại chị bầu")
                {
                    str_d = c;


                }

                if (dem == 2)
                {
                    //MessageBox.Show(c, "luc nay c la : ");

                    //MessageBox.Show(str_d, "phim duoc chon la");
                    str_e = c;
                    //MessageBox.Show(str_e, "loai ve str_e:");

                }
                if (dem == 3)
                {

                    //MessageBox.Show(str_e, "thong bao str_e");
                    int bao = c.Length;
                    int khang = 0;
                    while (bao != 0)
                    {
                        khang++;
                        bao = bao - 3;
                    }
                    //MessageBox.Show(khang.ToString(), "thong bao so ve");
                    for (int k = 1; k <= khang; k++)
                    {
                        //MessageBox.Show("da vao vong loop", "thong bao");
                        //MessageBox.Show(str_d, "phim duoc chon la");
                        //MessageBox.Show(str_e, "loai ve ban chon");
                        if (str_d == "Đào, phở và piano")
                        {
                            c1++;
                            countban[0] = c1;
                            a1 -= 1;
                            countconlai[0] = a1;
                            b1 = (float)c1 / 105;
                            tile[0] = b1;
                            if (str_e == "vé thường")
                            {

                                d1 += 45000;
                            }
                            if (str_e == "vé vớt")
                            {
                                d1 += 45000 / 4;
                            }
                            if (str_e == "vé vip")
                            {
                                d1 += 45000 * 2;
                            }
                        }
                        if (str_d == "Mai")
                        {
                            c2++;
                            countban[1] = c2;
                            a2 -= 1;
                            countconlai[1] = a2;
                            b2 = (float)c2 / 105;
                            tile[1] = b2;
                            //MessageBox.Show("inloading", "da tinh doanh thu");

                            if (str_e == "vé vớt")
                            {
                                d2 += 100000 / 4;
                            }
                            if (str_e == "vé vip")
                            {
                                d2 += 100000 * 2;
                            }
                            if (str_e == "vé thường")
                            {
                                d2 += 100000;

                            }
                        }
                        if (str_d == "Tarot")
                        {
                            c3++;
                            countban[2] = c3;
                            a3 -= 1;
                            countconlai[2] = a3;
                            b3 = (float)c3 / 105;
                            tile[2] = b3;
                            if (str_e == "vé thường")
                            {
                                d3 += 90000;
                            }
                            if (str_e == "vé vớt")
                            {
                                d3 += 90000 / 4;
                            }
                            if (str_e == "vé vip")
                            {
                                d3 += 90000 * 2;
                            }
                        }
                        if (str_d == "Gặp lại chị bầu")
                        {
                            c4++;
                            countban[3] = c4;
                            a4 -= 1;
                            countconlai[3] = a4;
                            b4 = (float)c4 / 105;
                            tile[3] = b4;
                            if (str_e == "vé thường")
                            {
                                d4 += 70000;
                            }
                            if (str_e == "vé vớt")
                            {
                                d4 += 70000 / 4;
                            }
                            if (str_e == "vé vip")
                            {
                                d4 += 70000 * 2;
                            }
                        }
                    }
                    //MessageBox.Show(d2.ToString(), "thong bao tien Mai");
                    doanhthu[0] = d1;
                    doanhthu[1] = d2;
                    doanhthu[2] = d3;
                    doanhthu[3] = d4;
                }
                if (dem == 4)
                {
                    continue;
                }
                if (dem == 5)
                {
                    dem = 0;

                }

            }





            xephang = XHP(doanhthu);


            if (txtnameoffilm.Text == tenphim[0])
            {
                txtSLsale.Text = countban[0].ToString();
                txtSLremain.Text = countconlai[0].ToString();
                txtpercentticket.Text = tile[0].ToString() + "%";
                txtoverall.Text = doanhthu[0].ToString();
                txtsolorank.Text = xephang[0].ToString();
            }
            if (txtnameoffilm.Text == tenphim[1])
            {
                txtSLsale.Text = countban[1].ToString();
                txtSLremain.Text = countconlai[1].ToString();
                txtpercentticket.Text = tile[1].ToString() + "%";
                txtoverall.Text = doanhthu[1].ToString();
                txtsolorank.Text = xephang[1].ToString();
            }
            if (txtnameoffilm.Text == tenphim[2])
            {
                txtSLsale.Text = countban[2].ToString();
                txtSLremain.Text = countconlai[2].ToString();
                txtpercentticket.Text = tile[2].ToString() + "%";
                txtoverall.Text = doanhthu[2].ToString();
                txtsolorank.Text = xephang[2].ToString();
            }
            if (txtnameoffilm.Text == tenphim[3])
            {
                txtSLsale.Text = countban[3].ToString();
                txtSLremain.Text = countconlai[3].ToString();
                txtpercentticket.Text = tile[3].ToString() + "%";
                txtoverall.Text = doanhthu[3].ToString();
                txtsolorank.Text = xephang[3].ToString();
            }
            a1 = 45;
            a2 = 30;
            a3 = 15;
            a4 = 15;
        }
        public string[] XHP(long[] a)
        {
            string[] ranking = new string[4] { "1", "2", "3", "4" };
            string l = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (a[i] < a[j])
                    {
                        l = ranking[i];
                        ranking[i] = ranking[j];
                        ranking[j] = l;
                    }
                }
            }


            return ranking;
        }

        private void btshow_Click(object sender, EventArgs e)
        {

            if (txtnameoffilm.Text == tenphim[0])
            {
                txtSLsale.Text = countban[0].ToString();
                txtSLremain.Text = countconlai[0].ToString();
                txtpercentticket.Text = tile[0].ToString() + "%";
                txtoverall.Text = doanhthu[0].ToString();
                txtsolorank.Text = xephang[0].ToString();
            }
            if (txtnameoffilm.Text == tenphim[1])
            {
                txtSLsale.Text = countban[1].ToString();
                txtSLremain.Text = countconlai[1].ToString();
                txtpercentticket.Text = tile[1].ToString() + "%";
                txtoverall.Text = doanhthu[1].ToString();
                txtsolorank.Text = xephang[1].ToString();
            }
            if (txtnameoffilm.Text == tenphim[2])
            {
                txtSLsale.Text = countban[2].ToString();
                txtSLremain.Text = countconlai[2].ToString();
                txtpercentticket.Text = tile[2].ToString() + "%";
                txtoverall.Text = doanhthu[2].ToString();
                txtsolorank.Text = xephang[2].ToString();
            }
            if (txtnameoffilm.Text == tenphim[3])
            {
                txtSLsale.Text = countban[3].ToString();
                txtSLremain.Text = countconlai[3].ToString();
                txtpercentticket.Text = tile[3].ToString() + "%";
                txtoverall.Text = doanhthu[3].ToString();
                txtsolorank.Text = xephang[3].ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                rtxtfile.Text += tenphim[i].ToString()
                                + "\n" + countban[i].ToString()
                                + "\n" + countconlai[i].ToString()
                                + "\n" + doanhthu[i].ToString()
                                + "\n" + xephang[i] + "\n";
            }
        }
    }
}
