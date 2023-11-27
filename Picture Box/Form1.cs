using Picture_Box.Properties;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (speechBubblePictureBox.Visible)
            {
                speechBubblePictureBox.Visible = false;
            }
            else
            {
                speechBubblePictureBox.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*    if(e.KeyCode == Keys.D) {
                    //     MessageBox.Show(pictureBox1.Location.ToString());
                    pictureBox1.Left += 10;
                }
                else if(e.KeyCode == Keys.A)
                {
                 pictureBox1.Right += 10;

                }*/
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

           
        }
    }
}