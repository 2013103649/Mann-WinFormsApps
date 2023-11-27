namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // closes the current form
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double hours = Convert.ToDouble(hoursTextBox.Text);
            double wage = Convert.ToDouble(wageTextBox.Text);
            double grossPay = hours * wage;
            double taxRate = Convert.ToDouble(taxRateTextBox.Text);

            double netPay = grossPay * ((100 - taxRate) / 100);

            MessageBox.Show(
                netPay.ToString(), // converts the double to String
                "Your gross pay is",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information

                );


        }
    }
}