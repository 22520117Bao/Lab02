using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2demo
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }


        private void btread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

            StreamReader os = new StreamReader(fs);
            string str = os.ReadToEnd();


            rtxtread.Text = str.ToString();
            string name = ofd.SafeFileName.ToString();
            txtname.Text = name;
            string url = fs.Name.ToString();
            txturl.Text = url;
            FileInfo fi = new FileInfo(ofd.FileName.ToString());
            txtsize.Text = fi.Length.ToString() + " byte";


            int cchar = 0;


            cchar = demsotu(str);

            int lines = 0;
            lines = demsodong(str);

            int sokitu = 0;
            sokitu = demsokitu(str);

            fs.Close();

            txtcharcount.Text = cchar.ToString();
            txtcount.Text = lines.ToString();
            txtchcount.Text = sokitu.ToString();


        }
        int demsotu(string str)
        {
            int dem = 1;
            //s = s.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                    dem++;
            }
            return (dem);

        }
        int demsodong(string str)
        {
            int lines = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    continue;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    continue;
                }
                else
                    if (str[i] == '\n')
                {
                    lines++;
                }

            }
            return lines;
        }
        int demsokitu(string str)
        {
            int clines = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    clines++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    clines++;
                }
                else

                {
                    clines++;
                }
            }
            return clines;
        }

        private void txtchcount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
