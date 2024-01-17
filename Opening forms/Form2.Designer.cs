namespace Opening_forms
{
    partial class Secondform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Displaylabel = new MaterialSkin.Controls.MaterialLabel();
            contenttxtbox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Displaylabel
            // 
            Displaylabel.Depth = 0;
            Displaylabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Displaylabel.Location = new Point(267, 248);
            Displaylabel.MouseState = MaterialSkin.MouseState.HOVER;
            Displaylabel.Name = "Displaylabel";
            Displaylabel.Size = new Size(211, 114);
            Displaylabel.TabIndex = 0;
            Displaylabel.Text = "materialLabel1";
            Displaylabel.Click += Displaylabel_Click;
            // 
            // contenttxtbox2
            // 
            contenttxtbox2.Location = new Point(364, 140);
            contenttxtbox2.Name = "contenttxtbox2";
            contenttxtbox2.Size = new Size(100, 23);
            contenttxtbox2.TabIndex = 1;
            contenttxtbox2.TextChanged += contenttxtbox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(403, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Secondform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(contenttxtbox2);
            Controls.Add(Displaylabel);
            Name = "Secondform";
            Text = "Form2";
            Load += Secondform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Displaylabel;
        private TextBox contenttxtbox2;
        private Button button1;
    }
}