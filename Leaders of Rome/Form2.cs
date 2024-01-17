using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaders_of_Rome
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(pictureBox4, "Augustus");
            toolTip1.SetToolTip(pictureBox3, "Tiberius");
            toolTip1.SetToolTip(pictureBox2, "Calaudius");
            toolTip1.SetToolTip(pictureBox1, "Caligula");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
