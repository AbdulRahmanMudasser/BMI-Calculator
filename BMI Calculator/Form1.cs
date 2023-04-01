using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tempInFah = Convert.ToDecimal(textBox1.Text);
            decimal tempInCel = (5 / 9) * (tempInFah - 32) ;

            textBox2.Text = Convert.ToString(tempInCel);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
