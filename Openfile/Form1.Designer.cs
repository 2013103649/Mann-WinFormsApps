
namespace Openfile
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Fileselectordialog = new System.Windows.Forms.OpenFileDialog();
            this.contentTextbox = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(119, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 328);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(400, 390);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(144, 23);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "No Image Selected";
            // 
            // Fileselectordialog
            // 
            this.Fileselectordialog.Multiselect = true;
            this.Fileselectordialog.Title = "Image selector";
            // 
            // contentTextbox
            // 
            this.contentTextbox.AnimateReadOnly = false;
            this.contentTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contentTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.contentTextbox.Depth = 0;
            this.contentTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contentTextbox.HideSelection = true;
            this.contentTextbox.LeadingIcon = null;
            this.contentTextbox.Location = new System.Drawing.Point(709, 215);
            this.contentTextbox.MaxLength = 32767;
            this.contentTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.contentTextbox.Name = "contentTextbox";
            this.contentTextbox.PasswordChar = '\0';
            this.contentTextbox.PrefixSuffixText = null;
            this.contentTextbox.ReadOnly = false;
            this.contentTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contentTextbox.SelectedText = "";
            this.contentTextbox.SelectionLength = 0;
            this.contentTextbox.SelectionStart = 0;
            this.contentTextbox.ShortcutsEnabled = true;
            this.contentTextbox.Size = new System.Drawing.Size(250, 48);
            this.contentTextbox.TabIndex = 3;
            this.contentTextbox.TabStop = false;
            this.contentTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contentTextbox.TrailingIcon = null;
            this.contentTextbox.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 561);
            this.Controls.Add(this.contentTextbox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.OpenFileDialog Fileselectordialog;
        private MaterialSkin.Controls.MaterialTextBox2 contentTextbox;
    }
}

