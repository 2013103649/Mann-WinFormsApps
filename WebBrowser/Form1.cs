namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate(urlTextBox.Text);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.ShowPrintUI();
        }
    }
}