using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Openfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // only allows selection of image files
            // Fileselectordialog.Filter = "Image files |*.png;*.jpg;*.jpeg;*.ico;";
            // only allows selection of text files
            Fileselectordialog.Filter = "Text file|*.txt;";

            Fileselectordialog.InitialDirectory = @"C:\Users\2013.103649\Downloads";
            Fileselectordialog.ShowDialog();
            if (Fileselectordialog.ShowDialog() == DialogResult.OK)
            {
                //ictureBox1.Image = Image.FromFile(Fileselectordialog.FileName);
                contentTextbox.Text = Fileselectordialog.FileName;
                materialLabel1.Text = Fileselectordialog.SafeFileName;
            }
            
        }
    }
}
