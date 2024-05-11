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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2demo
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                tvinput.Nodes.Add(node);
                ThemNode(node);
            }
        }
        private void ThemNode(TreeNode nodecha)
        {
            DirectoryInfo[] danhmuc = ((DirectoryInfo)nodecha.Tag).GetDirectories();
            AddNodes(nodecha, danhmuc);

            FileInfo[] files = ((DirectoryInfo)nodecha.Tag).GetFiles();
            AddNodes(nodecha, files);
        }
        private void AddNodes(TreeNode nodecha, FileSystemInfo[] items)
        {
            foreach (var it in items)
            {
                TreeNode node;
                if (it is DirectoryInfo danhmuc)
                {
                    node = new TreeNode(danhmuc.Name);
                    node.Tag = danhmuc;
                    node.Nodes.Add("");
                }
                else
                {
                    node = new TreeNode(it.Name);
                    node.Tag = it;
                }
                nodecha.Nodes.Add(node);
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo danhmuc)
            {

                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Remove();
                }
                DirectoryInfo[] subDirectories = danhmuc.GetDirectories();
                AddNodes(e.Node, subDirectories);
                FileInfo[] files = danhmuc.GetFiles();
                AddNodes(e.Node, files);
            }
            else if (e.Node.Tag is FileInfo file)
            {

                if (IsImage(file.FullName))
                {
                    XuatHinhAnh(file.FullName);
                }
                else
                {
                    XuatVanBan(file.FullName);
                }
            }
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "")
            {

                e.Node.Nodes.Clear();
                ThemNode(e.Node);
            }
        }
        private bool IsImage(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(filePath);
            return imageExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }
        private void XuatHinhAnh(string imagePath)
        {
            try
            {
                rtxtfile.Visible = false;
                picboxkq.Visible = true;
                Image image = Image.FromFile(imagePath);
                picboxkq.Image = image;
                picboxkq.SizeMode = PictureBoxSizeMode.Normal;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void XuatVanBan(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                rtxtfile.Text = content;
                rtxtfile.Visible = true;
                picboxkq.Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void tvinput_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
