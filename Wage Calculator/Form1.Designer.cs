namespace Wage_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            calculateBtn = new Button();
            exitBtn = new Button();
            hoursPrompt = new Label();
            wagePrompt = new Label();
            hoursTextBox = new TextBox();
            wageTextBox = new TextBox();
            taxPrompt = new Label();
            taxRateTextBox = new TextBox();
            SuspendLayout();
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(47, 143);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(109, 56);
            calculateBtn.TabIndex = 0;
            calculateBtn.Text = "Calculate Net Pay";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(188, 176);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // hoursPrompt
            // 
            hoursPrompt.AutoSize = true;
            hoursPrompt.Location = new Point(12, 9);
            hoursPrompt.Name = "hoursPrompt";
            hoursPrompt.Size = new Size(144, 15);
            hoursPrompt.TabIndex = 2;
            hoursPrompt.Text = "Number of Hours Worked";
            // 
            // wagePrompt
            // 
            wagePrompt.AutoSize = true;
            wagePrompt.Location = new Point(12, 52);
            wagePrompt.Name = "wagePrompt";
            wagePrompt.Size = new Size(69, 15);
            wagePrompt.TabIndex = 3;
            wagePrompt.Text = "Hourly Rate";
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(163, 9);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(100, 23);
            hoursTextBox.TabIndex = 4;
            // 
            // wageTextBox
            // 
            wageTextBox.Location = new Point(163, 52);
            wageTextBox.Name = "wageTextBox";
            wageTextBox.Size = new Size(100, 23);
            wageTextBox.TabIndex = 5;
            // 
            // taxPrompt
            // 
            taxPrompt.AutoSize = true;
            taxPrompt.Location = new Point(12, 104);
            taxPrompt.Name = "taxPrompt";
            taxPrompt.Size = new Size(50, 15);
            taxPrompt.TabIndex = 6;
            taxPrompt.Text = "Tax Rate";
            // 
            // taxRateTextBox
            // 
            taxRateTextBox.Location = new Point(163, 96);
            taxRateTextBox.Name = "taxRateTextBox";
            taxRateTextBox.Size = new Size(100, 23);
            taxRateTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 211);
            Controls.Add(taxRateTextBox);
            Controls.Add(taxPrompt);
            Controls.Add(wageTextBox);
            Controls.Add(hoursTextBox);
            Controls.Add(wagePrompt);
            Controls.Add(hoursPrompt);
            Controls.Add(exitBtn);
            Controls.Add(calculateBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Wage Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateBtn;
        private Button exitBtn;
        private Label hoursPrompt;
        private Label wagePrompt;
        private TextBox hoursTextBox;
        private TextBox wageTextBox;
        private Label taxPrompt;
        private TextBox taxRateTextBox;
    }
}