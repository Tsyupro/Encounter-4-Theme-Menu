namespace Encounter_4_Theme_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ1 dZ1 = new DZ1();
            dZ1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DZ2 dZ = new DZ2();
            dZ.ShowDialog();
        }
    }
}