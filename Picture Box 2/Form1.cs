using Picture_Box_2.Properties;

namespace Picture_Box_2
{
    public partial class Form1 : Form
    {
        static bool isItHeads = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isItHeads)
            {
                pictureBox1.Image = Resources.Tails;
                isItHeads = false;
            }
            else
            {
                pictureBox1.Image = Resources.Heads;
                isItHeads = true;
            }
        }
    }
}