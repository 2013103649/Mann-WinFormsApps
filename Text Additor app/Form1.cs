using MaterialSkin.Controls;

namespace Text_Additor_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Text file|*.txt;";

            openFile.InitialDirectory = @"C:\Users\2013.103649\Downloads";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                txt2.Text = openFile.FileName;
                txt1.Text = openFile.SafeFileName;
                txt2.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Text Files |*txt";
            saveFile.FileName = txt1.Text;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string address = Path.GetFullPath(saveFile.FileName); 
                string contents = txt2.Text;
                File.WriteAllText(address, contents);

                MessageBox.Show("Successfully saves", "Saving Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
