using System.IO;

namespace Encounter_4_Theme_Menu
{
    public partial class DZ2 : Form
    {
        private string currentPath = "";
        public DZ2()
        {
            InitializeComponent();

            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                listBoxDrives.Items.Add(drive);
            }

        }


        private void listBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPath = listBoxDrives.SelectedItem.ToString();
            UpdateFolderTree();
            UpdateAddressBar();
            UpdateContentList();
        }

        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentPath = e.Node.FullPath;
            UpdateAddressBar();
            UpdateContentList();
        }

        private void listViewContent_DoubleClick(object sender, EventArgs e)
        {
            if (listViewContent.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewContent.SelectedItems[0];
                if (item.ImageIndex == 0)
                {
                    currentPath = Path.Combine(currentPath, item.Text);
                    UpdateFolderTree();
                    UpdateAddressBar();
                    UpdateContentList();
                }
            }
        }

        private void UpdateFolderTree()
        {
            DirectoryInfo directory = new DirectoryInfo(currentPath);
            TreeNode rootNode = new TreeNode(directory.Name);

            try
            {
                foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(subDirectory.Name);
                    subNode.Nodes.Add("*"); 
                    rootNode.Nodes.Add(subNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            treeViewFolders.Nodes.Add(rootNode);
        }

        private void UpdateAddressBar()
        {
            textBoxAddress.Text = currentPath;
        }

        private void UpdateContentList()
        {
            listViewContent.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(currentPath);
            try
            {
                foreach (DirectoryInfo d in directory.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(d.Name);
                    item.ImageIndex = 0;
                    listViewContent.Items.Add(item);
                }
                foreach (FileInfo f in directory.GetFiles())
                {
                    ListViewItem item = new ListViewItem(f.Name);
                    item.ImageIndex = 1;
                    item.SubItems.Add(f.Length.ToString());
                    listViewContent.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Доступ к этой папке запрещен");
            }
        }

    }
}

