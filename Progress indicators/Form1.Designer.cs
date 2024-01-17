namespace Progress_indicators
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar2 = new ProgressBar();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(618, 182);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "materialLabel1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(590, 236);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(198, 23);
            progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(618, 299);
            button1.Name = "button1";
            button1.Size = new Size(136, 25);
            button1.TabIndex = 2;
            button1.Text = "Start Downloading";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(176, 236);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(208, 28);
            progressBar2.TabIndex = 3;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(227, 182);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(107, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "materialLabel2";
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            backgroundWorker2.ProgressChanged += backgroundWorker2_ProgressChanged;
            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialLabel2);
            Controls.Add(progressBar2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(materialLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ProgressBar progressBar1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
