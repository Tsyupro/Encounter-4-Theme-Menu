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
using static System.Net.Mime.MediaTypeNames;

namespace Encounter_4_Theme_Menu
{
    public partial class DZ2 : Form
    {

        TreeNode tree = new TreeNode();
        public DZ2()
        {
            InitializeComponent();
        }


        private void TestForm_Load(object sender, EventArgs e)
        {
            
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drives)
            {
                TreeNode drivenode = new TreeNode(driveInfo.Name);
                
                drivenode.Nodes.Add("*");
                listView1.Items.Add(driveInfo.Name);
                treeView1.Nodes.Add(drivenode);
            }
            //treeView1.Nodes.Add(new TreeNode(driveInfo.Name));
        }


        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
            listView1.Clear();
            textBox1.Text= e.Node.Text;
            foreach (string item in Directory.GetDirectories(e.Node.Text))
            {
                string name = item.Remove(0, e.Node.Text.Length);
                listView1.Items.Add(name);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private TreeNode PopulateTreeNode(string path, TreeNode node)
        {
            try
            {
                foreach (string item in Directory.GetDirectories(path))
                {
                    TreeNode itemNode = new TreeNode(item);
                    if(Directory.GetDirectories(item).Length != 0)
                    {
                        itemNode.Nodes.Add("*");
                    }
                    node.Nodes.Add(itemNode);
                
                }
            }
            catch
            {

            }
            return node;
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();
            
            PopulateTreeNode(e.Node.Text,e.Node);
        }
    }
}
