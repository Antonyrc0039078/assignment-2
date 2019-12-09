using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1 = double.Parse(textBox1.Text);
            double R2 = double.Parse(textBox2.Text);

            double RT = (R1 + R2);

            MessageBox.Show("RT = " + RT + " Ohms");

           

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            double R3 = double.Parse(textBox3.Text);
            double R4 = double.Parse(textBox4.Text);

            double TR = (1 / (1 / R3) + (1 / R4));

            MessageBox.Show("RT = " + TR + " Ohms");
        }
    }
}
