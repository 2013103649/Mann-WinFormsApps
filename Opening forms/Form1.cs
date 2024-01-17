namespace Opening_forms
{
    public partial class Firstform : Form
    {
        public Firstform(string val = "ok")
        {
            InitializeComponent();
            displaylabel2.Text = val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = Contenttxtbox.Text;
            Secondform second = new Secondform(value);
            second.ShowDialog();
            this.Hide();


        }

        private void Firstform_Load(object sender, EventArgs e)
        {

        }

        private void displaylabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
