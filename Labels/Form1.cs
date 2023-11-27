namespace Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bottomLeftLabel_Click(object sender, EventArgs e)
        {
            bottomLeftLabel.Text = "Bottom Left";
        }

        private void bottomCenterLabel_Click(object sender, EventArgs e)
        {
            bottomCenterLabel.Text = "Bottom Center";
        }

        private void bottomRightLabel_Click(object sender, EventArgs e)
        {
            bottomRightLabel.Text = "Bottom Right";
        }

        private void topLeftLabel_Click(object sender, EventArgs e)
        {
            String word = topLeftLabel.Text;
            if (word == "Top Left")
            {
                topLeftLabel.Text = "";



            }
            else
            {
                topLeftLabel.Text = "Top Left";

            }

        }

        private void topCenterLabel_Click(object sender, EventArgs e)
        {
            topCenterLabel.Text = "Top Center";
        }

        private void topRightLabel_Click(object sender, EventArgs e)
        {
            topRightLabel.Text = "Top Right";
        }

        private void middleLeftLabel_Click(object sender, EventArgs e)
        {
            middleLeftLabel.Text = "Middle Left";
        }

        private void middleCenterLabel_Click(object sender, EventArgs e)
        {
            middleCenterLabel.Text = "Middle Center";
        }

        private void rightMiddleLabel_Click(object sender, EventArgs e)
        {
            rightMiddleLabel.Text = "Middle Right";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int zoomLevel = trackBar1.Value;
            topLeftLabel.Text = zoomLevel.ToString();
            int originalWidth = pictureBox1.Image.Width;
            int originalHeight = pictureBox1.Image.Height;

            // Calculate the new dimensions based on the zoom level
            int newWidth = (int)(originalWidth * (1 + zoomLevel * 0.01));
            int newHeight = (int)(originalHeight * (1 + zoomLevel * 0.01));

            // Update the PictureBox size
            pictureBox1.Size = new Size(newWidth, newHeight);
        }
    }
}