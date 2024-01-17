using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opening_forms
{
    public partial class Secondform : Form
    {
        public Secondform(string value)
        {
            InitializeComponent();
            Displaylabel.Text = value;
        }

        private void Secondform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = contenttxtbox2.Text;
            Firstform first = new Firstform(val);
            first.ShowDialog();
            this.Hide();
        }

        private void Displaylabel_Click(object sender, EventArgs e)
        {

        }

        private void contenttxtbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
