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
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;


namespace Lab2demo
{
    

    public partial class Bai4 : Form
    {
        static int dem = 0;
        static int count = 0;
        string[] b = new string[1000];
        static string a1 = "";
        static int a2 = 0;
        static string a3 = "";
        static float a4 = 0;
        static float a5 = 0;
        static float a6 = 0;
        static float a7 = 0;
        public Bai4()
        {
            InitializeComponent();
        }
        class SinhVien
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float avrg { get; set; }
            public string phone { get; set; }
            public SinhVien(string name, int id, string dt ,float course1 , float course2 , float course3 , float avr )
            {
                Name = name;
                ID = id;
                phone = dt;
                Course1 = course1;
                Course2 = course2;
                Course3 = course3;
                avrg = avr;
            }
            public override string ToString()
            {
                return $"{Name}\n{ID}\n{phone}\n{Course1}\n{Course2}\n{Course3}\n{avrg}\n\n\n";
            }
        }

        List<SinhVien> people = new List<SinhVien>();
        private void btwrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
           
            
            SerializeToFileStream(ofd.FileName, people);
            a1 = "";
            a2 = 0;
            a3 = "";
            a4 = a5 = a6 = a7 = 0;
            rtxtfile.Text = "";
           
           
            //FileStream fs = new FileStream(ofd.FileName, FileMode.Create);

            //StreamWriter swrite = new StreamWriter(fs);

            //swrite.Write(rtxtfile.Text);
            //swrite.Flush(); //  se chuyen moi thu trong Luong ra ngoai tep // Dieu nay co the thuc hien giua qua trinh su dung Luong va ban co the tiep tuc viet
            //fs.Close(); // Dieu nay
        }

        private void btadd_Click(object sender, EventArgs e)
        {

            string Name = "";
            int ID = 0;
            string phone = "";
            float Course1 = 0;
            float Course2 = 0;
            float Course3 = 0;
            float avrg = 0;
            string q = "";
            Name = txtinname.Text;
            q += Name + "\n";
            a1  = Name;
            if (int.Parse(txtinID.Text) > 9999999)
            {
                ID = int.Parse(txtinID.Text);
                q += ID + "\n";
                a2 = ID;
            }
            else
            {
                MessageBox.Show("moi ban nhap lai >= 100000000", "thong bao");
                txtinID.Text = "";
            }
            if (txtinPhone.Text.Length == 10)
            {
                phone = txtinPhone.Text;
                q += phone + "\n";
                a3 = phone;
            }
            else
            {
                MessageBox.Show("moi ban nhap lai SDT ", "thong bao");
                txtinPhone.Text = "";
            }
            if (float.Parse(txtinc1.Text) >= 0 && float.Parse(txtinc1.Text) <= 10)
            {
                Course1 = float.Parse(txtinc1.Text);
                q += Course1 + "\n";
                a4 = Course1;
            }
            else
            {
                MessageBox.Show("moi ban nhap lai diem mon 1 ", "thong bao");
                txtinc1.Text = "";
            }
            if (float.Parse(txtinc2.Text) >= 0 && float.Parse(txtinc2.Text) <= 10)
            {
                Course2 = float.Parse(txtinc2.Text);
                q += Course2 + "\n";
                a5 = Course2;
            }
            else
            {
                MessageBox.Show("moi ban nhap lai diem mon 2 ", "thong bao");
                txtinc2.Text = "";
            }
            if (float.Parse(txtinc3.Text) >= 0 && float.Parse(txtinc3.Text) <= 10)
            {
                Course3 = float.Parse(txtinc3.Text);
                q += Course3 + "\n";
                a6 = Course3;
            }
            else
            {
                MessageBox.Show("moi ban nhap lai diem mon 3 ", "thong bao");
                txtinc3.Text = "";
            }
            avrg = 0;
            a7 = 0;
            q += avrg + "\n\n\n";
            MessageBox.Show(q, "Chuoi cua q la: ");
            b[dem] = q;
            MessageBox.Show(b[dem], "chuoi cua b la: ");
            dem++;

            rtxtfile.Text += q;
            people.Add(new SinhVien(a1, a2, a3, a4, a5, a6, a7));

        }

        private void btread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            List<SinhVien> deserializedPeopleStream = DeserializeFromFileStream(ofd.FileName);
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sread = new StreamReader(fs);
            string str = sread.ReadToEnd();

            rtxtfile.Text = str;

            fs.Close();
            Console.ReadLine();
            //foreach (var person in deserializedPeopleStream)
            //{
            //    rtxtfile.Text += person ;
            //}
            string c = "";
            c = b[0];
            count = 0;
            lbc.Text = count.ToString();
            string str_a = "";
            int x = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != '\n')
                {
                    str_a += c[i];
                }
                if (c[i] == '\n')
                {
                    if (x == 0)
                    {
                        txtoutName.Text = str_a;
                        a1 = str_a;
                        str_a = "";
                        x++;
                    }
                    else if (x == 1)
                    {
                        txtoutID.Text = str_a;
                        a2 = int.Parse(str_a);
                        str_a = "";
                        x++;
                    }
                    else if (x == 2)
                    {
                        txtoutPhone.Text = str_a;
                        a3 = str_a;
                        str_a = "";
                        x++;
                    }
                    else if (x == 3)
                    {
                        txtoutc1.Text = str_a;
                        a4 = float.Parse(str_a);
                        str_a = "";
                        x++;
                    }
                    else if (x == 4)
                    {
                        txtoutc2.Text = str_a;
                        a5 = float.Parse(str_a);
                        str_a = "";
                        x++;
                    }
                    else if (x == 5)
                    {
                        txtoutc3.Text = str_a;
                        a6 = float.Parse(str_a);
                        str_a = "";
                        x++;

                    }
                    else
                    {
                        float tb = (float)(float.Parse(txtoutc1.Text) + float.Parse(txtoutc2.Text) + float.Parse(txtoutc3.Text)) / 3;
                        a7 = tb;
                        txtoutavr.Text = tb.ToString();

                    }
                }
                if (c[i] == '\n' && c[i + 1] == '\n' && c[i + 1] == '\n')
                {

                    break;
                }
            }
            people = new List<SinhVien>();
            people.Add(new SinhVien(a1, a2, a3, a4, a5, a6, a7));

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                MessageBox.Show("khong the tiep tuc", "Warning");
                count = 0;
            }
            else
            {
                string c = "";
                c = b[count];
                string str_a = "";
                int x = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] != '\n')
                    {
                        str_a += c[i];
                    }
                    if (c[i] == '\n')
                    {
                        if (x == 0)
                        {
                            txtoutName.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 1)
                        {
                            txtoutID.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 2)
                        {
                            txtoutPhone.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 3)
                        {
                            txtoutc1.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 4)
                        {
                            txtoutc2.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 5)
                        {
                            txtoutc3.Text = str_a;
                            str_a = "";
                            x++;

                        }
                        else
                        {
                            float tb = (float)(float.Parse(txtoutc1.Text) + float.Parse(txtoutc2.Text) + float.Parse(txtoutc3.Text)) / 3;
                            txtoutavr.Text = tb.ToString();
                        }
                    }
                    if (c[i] == '\n' && c[i + 1] == '\n' && c[i + 1] == '\n')
                    {
                        break;
                    }
                }
                lbpage.Text = count.ToString();
            }

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            count++;
            if (count > dem)
            {
                MessageBox.Show("khong the tiep tuc ", "Warning");
                count--;
            }
            else
            {
                string c = "";
                c = b[count];
                string str_a = "";
                int x = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] != '\n')
                    {
                        str_a += c[i];
                    }
                    if (c[i] == '\n')
                    {
                        if (x == 0)
                        {
                            txtoutName.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 1)
                        {
                            txtoutID.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 2)
                        {
                            txtoutPhone.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 3)
                        {
                            txtoutc1.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 4)
                        {
                            txtoutc2.Text = str_a;
                            str_a = "";
                            x++;
                        }
                        else if (x == 5)
                        {
                            txtoutc3.Text = str_a;
                            str_a = "";
                            x++;

                        }
                        else
                        {
                            float tb = (float)(float.Parse(txtoutc1.Text) + float.Parse(txtoutc2.Text) + float.Parse(txtoutc3.Text)) / 3;
                            txtoutavr.Text = tb.ToString();
                        }



                    }
                }
                lbpage.Text = count.ToString();
            }
           

        }
        static void SerializeToFileStream(string filePath, List<SinhVien> sv)
        {
            try
            {
                // Create a new StreamWriter and FileStream
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write each person to the file
                    foreach (var person in sv)
                    {
                        writer.WriteLine($"{person.Name}\n{person.ID}\n{person.phone}\n{person.Course1}\n{person.Course2}\n{person.Course3}\n{person.avrg}\n\n\n");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Deserialize an object from a file using StreamReader
        static List<SinhVien> DeserializeFromFileStream(string filePath)
        {
            List<SinhVien> people = new List<SinhVien>();
            try
            {
                // Create a new StreamReader and FileStream
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    // Read each line from the file and create a Person object
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\n');
                        if (parts.Length == 2)
                        {
                            string name = parts[0];
                            int id = int.Parse(parts[1]);
                            string dt = parts[3];
                            float c1 = float.Parse(parts[4]);
                            float c2 = float.Parse(parts[5]);
                            float c3 = float.Parse(parts[6]);
                            float av = float.Parse(parts[7]);
                            people.Add(new SinhVien(name,id,dt,c1,c2,c3,av));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return people;

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            
            txtinname.Text = "";
            txtinPhone.Text = "";
            txtinID.Text = "";
            txtinc1.Text = "";
            txtinc2.Text = "";
            txtinc3.Text = "";
            txtinavr.Text = "";
        }

        private void btdeletertxt_Click(object sender, EventArgs e)
        {
            rtxtfile.Text = "";
        }
    }
}
