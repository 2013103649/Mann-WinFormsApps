namespace Leaders_of_Rome
{
    public partial class Form1 : Form
    {
        public Form1(string image )
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
    }
}
