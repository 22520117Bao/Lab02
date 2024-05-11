using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Security.Cryptography;
using System.Dynamic;

namespace Lab2demo
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
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
        private void btex_Click(object sender, EventArgs e)
        {
            string[] str = File.ReadAllLines(sp);
            string a = ketquatinh(str);
            rtxtfile.Text = a;
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
            
        }
       

        private void btfix_Click(object sender, EventArgs e)
        {

        }
        string ketquatinh(string[] str)
        {

            //MessageBox.Show("so dong: " + str.Length);
            string str_a = "";
            string str_b = "";


            for (int i = 0; i < str.Length; i++)
            {
                str_a = str[i];
                str_b += chuoi(str_a);

            }
            return str_b;



        }
        string chuoi(string str)
        {
            double[] a;
            a = new double[100000];
            string str_a = "";
            string str_b = "";
            string kq = "";
            double tong = 0;
            int j = 0;

            //MessageBox.Show(str);
            //MessageBox.Show(countl.ToString());
            //MessageBox.Show(str.Length.ToString());
            for (int i = 0; i < str.Length; i++)
            {


                if ((str[i] >= '0' && str[i] <= '9'))
                {
                    str_a += str[i];
                }

                else if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    //MessageBox.Show(str_a);
                    str_b += str[i];
                    a[j] = int.Parse(str_a);
                    j++;
                    str_a = "";
                }
                else
                {
                    continue;
                }

            }
            if (str_a != "")
            {
                a[j] = int.Parse(str_a);
            }
            //for (int i =0; i< str_b.Length+1; i++)
            //{
            //    MessageBox.Show(a[i].ToString());
            //}
            MessageBox.Show(str_b.ToString());
            int t = 1;
            tong = a[0];
            for (int i = 0; i < str_b.Length; i++)
            {
                //MessageBox.Show(a[i].ToString());
                if (str_b[i] == '+')
                {
                    tong += a[t];
                }
                if (str_b[i] == '-')
                {


                    tong = tong - a[t];
                }
                if (str_b[i] == '*')
                {
                    tong *= a[t];
                }
                if (str_b[i] == '/')
                {
                    tong = a[t] / tong;
                }
                t++;

            }

            kq = str + " = " + tong + "\n";



            return kq;


        }


    }
}
