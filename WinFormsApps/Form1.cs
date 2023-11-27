namespace WinFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // label1.Text = textBox1.Text.ToUpper();
            String word = textBox1.Text;
            label1.Text = word.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToLower();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            MessageBox.Show(
                "BAZINGA!!",    // the main text to be shown
                "Welcome Caption", // the caption
                MessageBoxButtons.YesNo, // different buttons that can be used
                MessageBoxIcon.Information,// different icons that can be used
                MessageBoxDefaultButton.Button2,// determines which button is highlighted by default
                MessageBoxOptions.ServiceNotification); // determines the general look and shape of the messagebox

            */

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?",
                  "Exit Confirmation",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2,
                   MessageBoxOptions.ServiceNotification
                  );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}