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

namespace TreeViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void addNode(TreeNode parenNode, string parenDirectory, int level)
        {
            try
            {
                if (level < 10)
                {
                    var directoryInfo = new DirectoryInfo(parenDirectory);
                    var directories = directoryInfo.GetDirectories();
                    if (directories.Length > 0)
                    {
                        foreach (var directory in directories)
                        {
                            TreeNode node = new TreeNode(directory.Name);
                            parenNode.Nodes.Add(node);

                            addNode(node, directory.FullName, level + 1);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btnTaoCay_Click(object sender, EventArgs e)
        {
            picLoading.Visible = true;
            BackgroundWorker worker = new BackgroundWorker();
            List<TreeNode> ls = new List<TreeNode>();
            worker.DoWork += (t, w) =>
            {

                var drives = Environment.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    TreeNode nodeDrive = new TreeNode(drive);
                    ls.Add(nodeDrive);
                    addNode(nodeDrive, drive, 1);
                }
            };
            worker.RunWorkerCompleted += (t, w) =>
            {
                treeView1.Nodes.AddRange(ls.ToArray());
                picLoading.Visible = false;
            };
            worker.RunWorkerAsync();
        }
        List<String> ls = new List<string> { ".JPG", ".PNG", ".GIF" };


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var file = Directory.GetFiles(e.Node.FullPath);
            int x = 0;
            foreach (var f in file)
            {
                ListViewItem item = new ListViewItem();
                if (ls.Contains(Path.GetExtension(f).ToUpperInvariant()))
                {
                    imageList1.Images.Add(Image.FromFile(f));
                    item.Text = Path.GetFileName(f);
                    item.ImageIndex = x;
                    x++;
                    listView1.Items.Add(item);

                }
                listView1.LargeImageList = imageList1;
            }
        }
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
