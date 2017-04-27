using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4
{
    public partial class Form1 : Form
    {
        int opType;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Text = "";
            opType = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Text = "";
            opType = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Text = "";
            opType = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Text = "";
            opType = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (opType == 1)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(label1.Text));
                    label1.Text = textBox1.Text;
                }

                if (opType == 2)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text));
                    label1.Text = textBox1.Text;
                }

                if (opType == 3)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label1.Text));
                    label1.Text = textBox1.Text;
                }

                if (opType == 4)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text));
                    label1.Text = textBox1.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }
    }
}
