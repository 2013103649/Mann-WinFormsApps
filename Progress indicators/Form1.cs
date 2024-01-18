namespace Progress_indicators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// setting the progresss bar value
         // progressbar1.value = 10;
         //incermenting the progresss bar value
         // progressBar1.Value += 10;

            // increment function increments the value by how much you have it
            //  progressBar1.Increment(10);

            backgroundWorker1.RunWorkerAsync();// starting the background worker
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 10; i <= 100; i += 10)
            {
                // calls the progress changed function of the backgroundworker
                backgroundWorker1.ReportProgress(i);
                // to make it slower, we make the thread sleep
                Thread.Sleep(500);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;
            circularProgressBar1.Text = e.ProgressPercentage.ToString() + "%";
            progressBar1.Value = e.ProgressPercentage;
            materialLabel1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Download completed", "Download completed", MessageBoxButtons.OK);

            if (dr == DialogResult.OK)
            {
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = "0%";

                progressBar1.Value = 0;
                materialLabel1.Text = "0%";
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int j = 10; j <= 100; j += 10)
            {
                backgroundWorker2.ReportProgress(j);
                Thread.Sleep(550);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            materialLabel2.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Download completed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
        }
    }
}
