namespace Text_Additor_app
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
            file = new MaterialSkin.Controls.MaterialLabel();
            Contents = new MaterialSkin.Controls.MaterialLabel();
            txt1 = new MaterialSkin.Controls.MaterialTextBox();
            txt2 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            open = new MaterialSkin.Controls.MaterialFloatingActionButton();
            exit = new MaterialSkin.Controls.MaterialFloatingActionButton();
            clear = new MaterialSkin.Controls.MaterialFloatingActionButton();
            save = new MaterialSkin.Controls.MaterialFloatingActionButton();
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            SuspendLayout();
            // 
            // file
            // 
            file.AutoSize = true;
            file.Depth = 0;
            file.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            file.Location = new Point(22, 37);
            file.MouseState = MaterialSkin.MouseState.HOVER;
            file.Name = "file";
            file.Size = new Size(61, 19);
            file.TabIndex = 0;
            file.Text = "File Title";
            // 
            // Contents
            // 
            Contents.AutoSize = true;
            Contents.Depth = 0;
            Contents.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Contents.Location = new Point(12, 146);
            Contents.MouseState = MaterialSkin.MouseState.HOVER;
            Contents.Name = "Contents";
            Contents.Size = new Size(93, 19);
            Contents.TabIndex = 1;
            Contents.Text = "File Contents";
            // 
            // txt1
            // 
            txt1.AnimateReadOnly = false;
            txt1.BorderStyle = BorderStyle.None;
            txt1.Depth = 0;
            txt1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt1.Hint = "Enter file Title";
            txt1.LeadingIcon = null;
            txt1.Location = new Point(155, 22);
            txt1.MaxLength = 50;
            txt1.MouseState = MaterialSkin.MouseState.OUT;
            txt1.Multiline = false;
            txt1.Name = "txt1";
            txt1.Size = new Size(211, 50);
            txt1.TabIndex = 3;
            txt1.Text = "";
            txt1.TrailingIcon = null;
            txt1.UseAccent = false;
            // 
            // txt2
            // 
            txt2.AnimateReadOnly = false;
            txt2.BackgroundImageLayout = ImageLayout.None;
            txt2.CharacterCasing = CharacterCasing.Normal;
            txt2.Depth = 0;
            txt2.HideSelection = true;
            txt2.Hint = "Enter text file contents";
            txt2.Location = new Point(155, 146);
            txt2.MaxLength = 32767;
            txt2.MouseState = MaterialSkin.MouseState.OUT;
            txt2.Name = "txt2";
            txt2.PasswordChar = '\0';
            txt2.ReadOnly = false;
            txt2.ScrollBars = ScrollBars.Vertical;
            txt2.SelectedText = "";
            txt2.SelectionLength = 0;
            txt2.SelectionStart = 0;
            txt2.ShortcutsEnabled = true;
            txt2.Size = new Size(211, 190);
            txt2.TabIndex = 4;
            txt2.TabStop = false;
            txt2.TextAlign = HorizontalAlignment.Left;
            txt2.UseAccent = false;
            txt2.UseSystemPasswordChar = false;
            txt2.Click += txt2_Click;
            // 
            // open
            // 
            open.Depth = 0;
            open.Icon = Properties.Resources.open_ico;
            open.Location = new Point(39, 351);
            open.MouseState = MaterialSkin.MouseState.HOVER;
            open.Name = "open";
            open.Size = new Size(56, 56);
            open.TabIndex = 5;
            open.Text = "materialFloatingActionButton1";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // exit
            // 
            exit.Depth = 0;
            exit.Icon = Properties.Resources.exit_ico;
            exit.Location = new Point(310, 351);
            exit.MouseState = MaterialSkin.MouseState.HOVER;
            exit.Name = "exit";
            exit.Size = new Size(56, 56);
            exit.TabIndex = 6;
            exit.Text = "materialFloatingActionButton2";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // clear
            // 
            clear.Depth = 0;
            clear.Icon = Properties.Resources.clear_ico;
            clear.Location = new Point(226, 351);
            clear.MouseState = MaterialSkin.MouseState.HOVER;
            clear.Name = "clear";
            clear.Size = new Size(56, 56);
            clear.TabIndex = 7;
            clear.Text = "materialFloatingActionButton3";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // save
            // 
            save.Depth = 0;
            save.Icon = Properties.Resources.save_ico;
            save.Location = new Point(130, 351);
            save.MouseState = MaterialSkin.MouseState.HOVER;
            save.Name = "save";
            save.Size = new Size(56, 56);
            save.TabIndex = 8;
            save.Text = "materialFloatingActionButton4";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 419);
            Controls.Add(save);
            Controls.Add(clear);
            Controls.Add(exit);
            Controls.Add(open);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(Contents);
            Controls.Add(file);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Text Writter and Reader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel file;
        private MaterialSkin.Controls.MaterialLabel Contents;
        private MaterialSkin.Controls.MaterialTextBox txt1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt2;
        private MaterialSkin.Controls.MaterialFloatingActionButton open;
        private MaterialSkin.Controls.MaterialFloatingActionButton exit;
        private MaterialSkin.Controls.MaterialFloatingActionButton clear;
        private MaterialSkin.Controls.MaterialFloatingActionButton save;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
    }
}
