using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2demo
{
    public partial class Bai6 : Form
    {
        string str_c = @"Data Source=GBAO\SQLEXPRESS;Initial Catalog=HNAG;Integrated Security=True;Encrypt=False";
        SqlConnection sqlcon = null;
        public Bai6()
        {
            InitializeComponent();
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtpicture.Text, FileMode.Open, FileAccess.Read);
            byte[] pic = new byte[fs.Length];
            fs.Read(pic, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return pic;
        }

        private void btNhapNguoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(str_c);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string IDNCC = txtidnd.Text;
                string HoVaTen = txthovaten.Text;
                string QuyenHan = txtquyenhan.Text;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO NGUOIDUNG VALUES('" + IDNCC + "','" + HoVaTen + "','" + QuyenHan + "')";
                sqlCmd.Connection = sqlcon;
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btdanhsachnguoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(str_c);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM NGUOIDUNG";
                sqlCmd.Connection = sqlcon;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                lstnd.Items.Clear();
                while (reader.Read())
                {
                    string IDNCC = reader.GetString(0);
                    string HoVaTen = reader.GetString(1);
                    string QuyenHan = reader.GetString(2);
                    ListViewItem lvi = new ListViewItem(IDNCC);
                    lvi.SubItems.Add(HoVaTen);
                    lvi.SubItems.Add(QuyenHan);
                    lstnd.Items.Add(lvi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btchonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "JPG files (*jpg) | *.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                txtpicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnhapmon_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(str_c);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string strCom = "INSERT INTO MonAn VALUES(@IDMA,@TenMonAn,@HinhAnh,@IDNCC)";
                SqlCommand com = new SqlCommand(strCom, sqlcon);
                com.Parameters.AddWithValue("@IDMA", txtmonan.Text);
                com.Parameters.AddWithValue("@TenMonAn", txtnamefood.Text);
                com.Parameters.AddWithValue("@HinhAnh", convertImageToBytes()); 
                com.Parameters.AddWithValue("@IDNCC", txtid.Text);
                com.ExecuteNonQuery();
                sqlcon.Close();
                txtmonan.Text = txtnamefood.Text = txtpicture.Text = txtid.Text = "";
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btxuatmon_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(str_c);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from MONAN", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgridfood.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btrandomselect_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(str_c);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("SELECT TOP 1 MONAN.IDMA, MONAN.TenMonAn, MONAN.HinhAnh, MONAN.IDNCC, NGUOIDUNG.HoVaTen, NGUOIDUNG.QuyenHan FROM MONAN INNER JOIN NGUOIDUNG ON MONAN.IDNCC = MONAN.IDNCC ORDER BY NEWID();", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgridkq.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
