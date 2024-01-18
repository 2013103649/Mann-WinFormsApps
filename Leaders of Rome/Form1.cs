namespace Leaders_of_Rome
{
    public partial class Firstform : Form
    {
        public Firstform()
        {
            InitializeComponent();

        }

        private void anToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondForm second = new SecondForm();
            second.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void currentItalianPrimeMinistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thirdform third = new Thirdform();
            third.ShowDialog();
        }
    }
}
