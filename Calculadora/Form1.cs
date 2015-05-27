using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
   
    public partial class Form1 : Form
    {
        Double n1, n2, res;
        int contvariavel=0,op=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";


            op = 1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";


            op = 2;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";


            op = 3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";    
            
            
            op = 4;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                res = n1 + n2;
            }
            else if (op == 2)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                res = n1 - n2;
            }
            else if (op == 3)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                res = n1 * n2;
            }
            else if (op == 4)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                res = n1 / n2;
            }
            textBox1.Text = Convert.ToString(res);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
