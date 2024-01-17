namespace Opening_forms
{
    partial class Firstform
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
            Contenttxtbox = new TextBox();
            button1 = new Button();
            displaylabel2 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // Contenttxtbox
            // 
            Contenttxtbox.Location = new Point(416, 227);
            Contenttxtbox.Name = "Contenttxtbox";
            Contenttxtbox.Size = new Size(100, 23);
            Contenttxtbox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(390, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // displaylabel2
            // 
            displaylabel2.Depth = 0;
            displaylabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            displaylabel2.Location = new Point(90, 292);
            displaylabel2.MouseState = MaterialSkin.MouseState.HOVER;
            displaylabel2.Name = "displaylabel2";
            displaylabel2.Size = new Size(183, 80);
            displaylabel2.TabIndex = 2;
            displaylabel2.Text = "materialLabel1";
            displaylabel2.Click += displaylabel2_Click;
            // 
            // Firstform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displaylabel2);
            Controls.Add(button1);
            Controls.Add(Contenttxtbox);
            Name = "Firstform";
            Text = "Form1";
            Load += Firstform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Contenttxtbox;
        private Button button1;
        private MaterialSkin.Controls.MaterialLabel displaylabel2;
    }
}
