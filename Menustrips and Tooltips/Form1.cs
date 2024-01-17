namespace Menustrips_and_Tooltips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening a new file");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(materialButton1, "Click on this button to open a new page");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
