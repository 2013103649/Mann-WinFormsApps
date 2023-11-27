namespace WinFormsApps
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
            btn1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlLight;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Location = new Point(152, 159);
            btn1.Name = "btn1";
            btn1.Size = new Size(102, 54);
            btn1.TabIndex = 0;
            btn1.Text = "Click Me!";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 112);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(152, 219);
            button1.Name = "button1";
            button1.Size = new Size(102, 54);
            button1.TabIndex = 3;
            button1.Text = "toUpper";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(152, 279);
            button2.Name = "button2";
            button2.Size = new Size(102, 54);
            button2.TabIndex = 4;
            button2.Text = "toLower";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(333, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Main Form";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button exitButton;
    }
}