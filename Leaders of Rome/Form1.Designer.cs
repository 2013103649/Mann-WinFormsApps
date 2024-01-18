namespace Leaders_of_Rome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firstform));
            menuStrip1 = new MenuStrip();
            ancientToolStripMenuItem = new ToolStripMenuItem();
            anToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            currentItalianPrimeMinistersToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ancientToolStripMenuItem, anToolStripMenuItem, currentItalianPrimeMinistersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ancientToolStripMenuItem
            // 
            ancientToolStripMenuItem.Name = "ancientToolStripMenuItem";
            ancientToolStripMenuItem.Size = new Size(22, 20);
            ancientToolStripMenuItem.Text = " ";
            // 
            // anToolStripMenuItem
            // 
            anToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripTextBox1 });
            anToolStripMenuItem.Image = (Image)resources.GetObject("anToolStripMenuItem.Image");
            anToolStripMenuItem.Name = "anToolStripMenuItem";
            anToolStripMenuItem.Size = new Size(170, 20);
            anToolStripMenuItem.Text = "Ancient Roman Emperors";
            anToolStripMenuItem.Click += anToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // currentItalianPrimeMinistersToolStripMenuItem
            // 
            currentItalianPrimeMinistersToolStripMenuItem.Image = Properties.Resources.rrrrrrr;
            currentItalianPrimeMinistersToolStripMenuItem.Name = "currentItalianPrimeMinistersToolStripMenuItem";
            currentItalianPrimeMinistersToolStripMenuItem.Size = new Size(195, 20);
            currentItalianPrimeMinistersToolStripMenuItem.Text = "Current Italian Prime Ministers";
            currentItalianPrimeMinistersToolStripMenuItem.Click += currentItalianPrimeMinistersToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(370, 27);
            label1.TabIndex = 1;
            label1.Text = "Click on the above options to see current and past Italian Leaders ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Firstform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Firstform";
            Text = "Leaders of Rome";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ancientToolStripMenuItem;
        private ToolStripMenuItem anToolStripMenuItem;
        private ToolStripMenuItem currentItalianPrimeMinistersToolStripMenuItem;
        private Label label1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox1;
    }
}
