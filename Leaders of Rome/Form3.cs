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
    public partial class Thirdform : Form
    {
        public Thirdform()
        {
            InitializeComponent();
        }

        private void Thirdform_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox4, "Silvio Berlusconi");
            toolTip1.SetToolTip(pictureBox3, "Lamberto Dini");
            toolTip1.SetToolTip(pictureBox2, "Romano Prodi");
            toolTip1.SetToolTip(pictureBox1, "Massimo D'Alema");
        }
    }
}
