using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            if (Fileselectordialog.ShowDialog() == DialogResult.OK)
            {
                //ictureBox1.Image = Image.FromFile(Fileselectordialog.FileName);
                contentTextbox.Text = Fileselectordialog.FileName;
                materialLabel1.Text = Fileselectordialog.SafeFileName;
                contentTextbox.Text = File.ReadAllText(Fileselectordialog.FileName);
            }
            
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
           // fileSaverDialog.Title = "File will be saved here";
            fileSaverDialog.Filter = "Text Files |*txt";
            if(fileSaverDialog.ShowDialog() == DialogResult.OK)
            {
                string address = Path.GetFullPath(fileSaverDialog.FileName); // gets the full path for the file
                string contents = contentTextbox.Text;
                File.WriteAllText(address, contents);

                MessageBox.Show("Successfully saves", "Saving Successfull",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
