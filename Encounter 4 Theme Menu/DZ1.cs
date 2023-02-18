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

namespace Encounter_4_Theme_Menu
{
    public partial class DZ1 : Form
    {
       private string openedPath = "";
        private RichTextBox richCansel = new RichTextBox();
        public DZ1()
        {
            InitializeComponent();
            this.Text = "Later, the path to the file will appear here";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Text = openedPath = ofd.FileName;
                StreamReader reader = File.OpenText(ofd.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        void SaveFileAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.txt) | *.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                openedPath = sfd.FileName;
                SaveFile(sfd.FileName);
            }
        }
        private void SaveFile(string path)
        {
            StreamWriter write = new StreamWriter(path);
            write.Write(richTextBox1.Text);
            write.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openedPath == "")
            {
                SaveFileAs();
            }
            else SaveFile(openedPath);
        }

        private void NewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richCansel.Text = richTextBox1.Text;
            openedPath = "";
            richTextBox1.Text = "";
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText.ToString());
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richCansel.Text = richTextBox1.Text;
            richTextBox1.Text += Clipboard.GetText();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richCansel.Text+= richTextBox1.Text;
            Clipboard.SetText(richTextBox1.SelectedText.ToString());
            string text = richTextBox1.SelectedText.ToString();
            string del = Clipboard.GetText();
            richTextBox1.SelectedText = text.Remove(text.IndexOf(del), del.Length);

        }

        private void CanselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richCansel.Text;
        }

        private void RegTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = richTextBox1.SelectionFont;
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void RegColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = richTextBox1.SelectionColor;
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = color.Color;
            }
        }

        private void RegFonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void SelectedAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }
    }
}
