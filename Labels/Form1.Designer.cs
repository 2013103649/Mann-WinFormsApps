namespace Labels
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
            topLeftLabel = new Label();
            topCenterLabel = new Label();
            topRightLabel = new Label();
            middleLeftLabel = new Label();
            middleCenterLabel = new Label();
            rightMiddleLabel = new Label();
            bottomLeftLabel = new Label();
            bottomCenterLabel = new Label();
            bottomRightLabel = new Label();
            SuspendLayout();
            // 
            // topLeftLabel
            // 
            topLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            topLeftLabel.Location = new Point(12, 23);
            topLeftLabel.Name = "topLeftLabel";
            topLeftLabel.Size = new Size(100, 46);
            topLeftLabel.TabIndex = 0;
            topLeftLabel.Click += topLeftLabel_Click;
            // 
            // topCenterLabel
            // 
            topCenterLabel.BorderStyle = BorderStyle.FixedSingle;
            topCenterLabel.Location = new Point(132, 23);
            topCenterLabel.Name = "topCenterLabel";
            topCenterLabel.Size = new Size(114, 46);
            topCenterLabel.TabIndex = 1;
            topCenterLabel.TextAlign = ContentAlignment.TopCenter;
            topCenterLabel.Click += topCenterLabel_Click;
            // 
            // topRightLabel
            // 
            topRightLabel.BorderStyle = BorderStyle.FixedSingle;
            topRightLabel.Location = new Point(263, 23);
            topRightLabel.Name = "topRightLabel";
            topRightLabel.Size = new Size(115, 46);
            topRightLabel.TabIndex = 2;
            topRightLabel.TextAlign = ContentAlignment.TopRight;
            topRightLabel.Click += topRightLabel_Click;
            // 
            // middleLeftLabel
            // 
            middleLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            middleLeftLabel.Location = new Point(12, 79);
            middleLeftLabel.Name = "middleLeftLabel";
            middleLeftLabel.Size = new Size(100, 50);
            middleLeftLabel.TabIndex = 3;
            middleLeftLabel.TextAlign = ContentAlignment.MiddleLeft;
            middleLeftLabel.Click += middleLeftLabel_Click;
            // 
            // middleCenterLabel
            // 
            middleCenterLabel.BorderStyle = BorderStyle.FixedSingle;
            middleCenterLabel.Location = new Point(132, 79);
            middleCenterLabel.Name = "middleCenterLabel";
            middleCenterLabel.Size = new Size(114, 50);
            middleCenterLabel.TabIndex = 4;
            middleCenterLabel.TextAlign = ContentAlignment.MiddleCenter;
            middleCenterLabel.Click += middleCenterLabel_Click;
            // 
            // rightMiddleLabel
            // 
            rightMiddleLabel.BorderStyle = BorderStyle.FixedSingle;
            rightMiddleLabel.Location = new Point(263, 79);
            rightMiddleLabel.Name = "rightMiddleLabel";
            rightMiddleLabel.Size = new Size(115, 50);
            rightMiddleLabel.TabIndex = 5;
            rightMiddleLabel.TextAlign = ContentAlignment.MiddleRight;
            rightMiddleLabel.Click += rightMiddleLabel_Click;
            // 
            // bottomLeftLabel
            // 
            bottomLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomLeftLabel.Location = new Point(12, 142);
            bottomLeftLabel.Name = "bottomLeftLabel";
            bottomLeftLabel.Size = new Size(100, 53);
            bottomLeftLabel.TabIndex = 6;
            bottomLeftLabel.TextAlign = ContentAlignment.BottomLeft;
            bottomLeftLabel.Click += bottomLeftLabel_Click;
            // 
            // bottomCenterLabel
            // 
            bottomCenterLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomCenterLabel.Location = new Point(132, 142);
            bottomCenterLabel.Name = "bottomCenterLabel";
            bottomCenterLabel.Size = new Size(114, 53);
            bottomCenterLabel.TabIndex = 7;
            bottomCenterLabel.TextAlign = ContentAlignment.BottomCenter;
            bottomCenterLabel.Click += bottomCenterLabel_Click;
            // 
            // bottomRightLabel
            // 
            bottomRightLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomRightLabel.Location = new Point(263, 142);
            bottomRightLabel.Name = "bottomRightLabel";
            bottomRightLabel.Size = new Size(115, 53);
            bottomRightLabel.TabIndex = 8;
            bottomRightLabel.TextAlign = ContentAlignment.BottomRight;
            bottomRightLabel.Click += bottomRightLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 226);
            Controls.Add(bottomRightLabel);
            Controls.Add(bottomCenterLabel);
            Controls.Add(bottomLeftLabel);
            Controls.Add(rightMiddleLabel);
            Controls.Add(middleCenterLabel);
            Controls.Add(middleLeftLabel);
            Controls.Add(topRightLabel);
            Controls.Add(topCenterLabel);
            Controls.Add(topLeftLabel);
            Name = "Form1";
            Text = "Label Alignment";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label topLeftLabel;
        private Label topCenterLabel;
        private Label topRightLabel;
        private Label middleLeftLabel;
        private Label middleCenterLabel;
        private Label rightMiddleLabel;
        private Label bottomLeftLabel;
        private Label bottomCenterLabel;
        private Label bottomRightLabel;
    }
}