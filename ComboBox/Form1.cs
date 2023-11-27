using MaterialSkin.Controls;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string value = comboBox1.Text;
            MessageBox.Show(value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "SelectedIndex:";
            label1.Text += comboBox1.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string value = materialComboBox1.Text;
            MessageBox.Show(value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            materialListBox1.SelectedIndex = listBox1.SelectedIndex;

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(materialMaskedTextBox1.Text);

            if (delete < 0 || delete > listBox1.Items.Count-1)
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                listBox1.Items.RemoveAt(delete);
                materialListBox1.Items.RemoveAt(delete);
            }
        }
    }
}