using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encounter_4_Theme_Menu
{
    public partial class MyProgram : Form
    {
        public MyProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem newItem = new ToolStripMenuItem(textBox1.Text);
            menuStrip1.Items.Add(newItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Items.Count > 0)
            {
                ((ToolStripMenuItem)menuStrip1.Items[menuStrip1.Items.Count - 1]).DropDownItems.Add(textBox2.Text);
            }
        }
    }
}
