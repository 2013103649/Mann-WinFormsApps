namespace WebBrowser
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
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            urlTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            goButton = new MaterialSkin.Controls.MaterialButton();
            previousButton = new MaterialSkin.Controls.MaterialButton();
            nextButton = new MaterialSkin.Controls.MaterialButton();
            printButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-250, 105);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(250, 120);
            materialDrawer1.TabIndex = 0;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.Transparent;
            webView.Location = new Point(2, 12);
            webView.Name = "webView";
            webView.Size = new Size(786, 388);
            webView.Source = new Uri("https://www.google.com/", UriKind.Absolute);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            // 
            // urlTextBox
            // 
            urlTextBox.AllowPromptAsInput = true;
            urlTextBox.AnimateReadOnly = false;
            urlTextBox.AsciiOnly = false;
            urlTextBox.BackgroundImageLayout = ImageLayout.None;
            urlTextBox.BeepOnError = false;
            urlTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            urlTextBox.Depth = 0;
            urlTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            urlTextBox.HidePromptOnLeave = false;
            urlTextBox.HideSelection = true;
            urlTextBox.InsertKeyMode = InsertKeyMode.Default;
            urlTextBox.LeadingIcon = null;
            urlTextBox.Location = new Point(12, 406);
            urlTextBox.Mask = "";
            urlTextBox.MaxLength = 32767;
            urlTextBox.MouseState = MaterialSkin.MouseState.OUT;
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PasswordChar = '\0';
            urlTextBox.PrefixSuffixText = null;
            urlTextBox.PromptChar = '_';
            urlTextBox.ReadOnly = false;
            urlTextBox.RejectInputOnFirstFailure = false;
            urlTextBox.ResetOnPrompt = true;
            urlTextBox.ResetOnSpace = true;
            urlTextBox.RightToLeft = RightToLeft.No;
            urlTextBox.SelectedText = "";
            urlTextBox.SelectionLength = 0;
            urlTextBox.SelectionStart = 0;
            urlTextBox.ShortcutsEnabled = true;
            urlTextBox.Size = new Size(250, 48);
            urlTextBox.SkipLiterals = true;
            urlTextBox.TabIndex = 2;
            urlTextBox.TabStop = false;
            urlTextBox.Text = "https://www.google.com/";
            urlTextBox.TextAlign = HorizontalAlignment.Left;
            urlTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            urlTextBox.TrailingIcon = null;
            urlTextBox.UseSystemPasswordChar = false;
            urlTextBox.ValidatingType = null;
            // 
            // goButton
            // 
            goButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            goButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            goButton.Depth = 0;
            goButton.HighEmphasis = true;
            goButton.Icon = null;
            goButton.Location = new Point(297, 409);
            goButton.Margin = new Padding(4, 6, 4, 6);
            goButton.MouseState = MaterialSkin.MouseState.HOVER;
            goButton.Name = "goButton";
            goButton.NoAccentTextColor = Color.Empty;
            goButton.Size = new Size(64, 36);
            goButton.TabIndex = 3;
            goButton.Text = "Go";
            goButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            goButton.UseAccentColor = false;
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // previousButton
            // 
            previousButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            previousButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            previousButton.Depth = 0;
            previousButton.HighEmphasis = true;
            previousButton.Icon = null;
            previousButton.Location = new Point(380, 409);
            previousButton.Margin = new Padding(4, 6, 4, 6);
            previousButton.MouseState = MaterialSkin.MouseState.HOVER;
            previousButton.Name = "previousButton";
            previousButton.NoAccentTextColor = Color.Empty;
            previousButton.Size = new Size(91, 36);
            previousButton.TabIndex = 4;
            previousButton.Text = "Previous";
            previousButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            previousButton.UseAccentColor = false;
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextButton.Depth = 0;
            nextButton.HighEmphasis = true;
            nextButton.Icon = null;
            nextButton.Location = new Point(494, 409);
            nextButton.Margin = new Padding(4, 6, 4, 6);
            nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            nextButton.Name = "nextButton";
            nextButton.NoAccentTextColor = Color.Empty;
            nextButton.Size = new Size(64, 36);
            nextButton.TabIndex = 5;
            nextButton.Text = "Next";
            nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextButton.UseAccentColor = false;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // printButton
            // 
            printButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            printButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            printButton.Depth = 0;
            printButton.HighEmphasis = true;
            printButton.Icon = null;
            printButton.Location = new Point(582, 409);
            printButton.Margin = new Padding(4, 6, 4, 6);
            printButton.MouseState = MaterialSkin.MouseState.HOVER;
            printButton.Name = "printButton";
            printButton.NoAccentTextColor = Color.Empty;
            printButton.Size = new Size(64, 36);
            printButton.TabIndex = 6;
            printButton.Text = "Print";
            printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            printButton.UseAccentColor = false;
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(printButton);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(goButton);
            Controls.Add(urlTextBox);
            Controls.Add(webView);
            Controls.Add(materialDrawer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private MaterialSkin.Controls.MaterialMaskedTextBox urlTextBox;
        private MaterialSkin.Controls.MaterialButton goButton;
        private MaterialSkin.Controls.MaterialButton previousButton;
        private MaterialSkin.Controls.MaterialButton nextButton;
        private MaterialSkin.Controls.MaterialButton printButton;
    }
}