namespace Encounter_4_Theme_Menu
{
    partial class DZ2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxDrives = new System.Windows.Forms.ListBox();
            this.listViewContent = new System.Windows.Forms.ListView();
            this.treeViewFolders = new System.Windows.Forms.TreeView();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxDrives
            // 
            this.listBoxDrives.FormattingEnabled = true;
            this.listBoxDrives.ItemHeight = 15;
            this.listBoxDrives.Location = new System.Drawing.Point(12, 12);
            this.listBoxDrives.Name = "listBoxDrives";
            this.listBoxDrives.Size = new System.Drawing.Size(333, 229);
            this.listBoxDrives.TabIndex = 0;
            this.listBoxDrives.SelectedIndexChanged += new System.EventHandler(this.listBoxDrives_SelectedIndexChanged);
            // 
            // listViewContent
            // 
            this.listViewContent.Location = new System.Drawing.Point(381, 12);
            this.listViewContent.Name = "listViewContent";
            this.listViewContent.Size = new System.Drawing.Size(567, 292);
            this.listViewContent.TabIndex = 1;
            this.listViewContent.UseCompatibleStateImageBehavior = false;
            this.listViewContent.DoubleClick += new System.EventHandler(this.listViewContent_DoubleClick);
            // 
            // treeViewFolders
            // 
            this.treeViewFolders.Location = new System.Drawing.Point(12, 324);
            this.treeViewFolders.Name = "treeViewFolders";
            this.treeViewFolders.Size = new System.Drawing.Size(550, 257);
            this.treeViewFolders.TabIndex = 2;
            this.treeViewFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFolders_AfterSelect);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(731, 511);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(368, 23);
            this.textBoxAddress.TabIndex = 3;
            // 
            // DZ2
            // 
            this.ClientSize = new System.Drawing.Size(1346, 622);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.treeViewFolders);
            this.Controls.Add(this.listViewContent);
            this.Controls.Add(this.listBoxDrives);
            this.Name = "DZ2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private ListBox listBoxDrives;
        private ListView listViewContent;
        private TreeView treeViewFolders;
        private TextBox textBoxAddress;
    }
}