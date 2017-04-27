using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public int flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void input1_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "1";
        }

        private void input2_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "2";
        }

        private void input3_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "3";
        }

        private void input4_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "4";
        }

        private void input5_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "5";
        }

        private void input6_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "6";
        }

        private void input7_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "7";
        }

        private void input8_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "8";
        }

        private void input9_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "9";
        }

        private void input0_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += "0";
        }

        private void inputDec_Click(object sender, EventArgs e)
        {
            if (flag == 5)
                output.Text = "";
            else
                output.Text += ".";
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            flag = 1;
            if (num1.Text == "")
                num1.Text = output.Text;
            else
                num2.Text = output.Text;

            output.Text = "";
            
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            flag = 2;
            if (num1.Text == "")
                num1.Text = output.Text;
            else
                num2.Text = output.Text;
            output.Text = "";
           
        }

        private void subButton_Click(object sender, EventArgs e)
        {

            if (num1.Text == "")
            {
                num1.Text = output.Text;
                flag = 3;
            }
            else
            {
                num2.Text = output.Text;
                flag = 6;
            }
            output.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            flag = 4;
            if (num1.Text == "")
                num1.Text = output.Text;
            else
                num2.Text = output.Text;
            output.Text = "";
           
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            

            if (flag == 1)
            {
                if (num2.Text == "")
                {
                    if (Convert.ToDouble(output.Text) == 0)
                        output.Text = "ERROR";
                    else
                    {
                        output.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(output.Text));
                        outputLabel.Text = output.Text;
                    }
                }
                else
                    output.Text = Convert.ToString(Convert.ToDouble(num2.Text) / Convert.ToDouble(output.Text));
            }
            else if (flag == 2)
            {
                if (num2.Text == "")
                {
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(output.Text));
                    outputLabel.Text = output.Text;
                }
                else
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
            }
            else if (flag == 3)
            {
                if (num2.Text == "")
                {
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(output.Text));
                    outputLabel.Text = output.Text;
                }
                else
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
            }
            else if (flag == 4)
            {
                if (num2.Text == "")
                {
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(output.Text));
                    outputLabel.Text = output.Text;
                }
                else
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
            }
            else if (flag == 5)
                output.Text = outputLabel.Text;
            else if (flag == 6)
            {
                if (num2.Text == "")
                {
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(output.Text));
                    outputLabel.Text = output.Text;
                }
                else
                    output.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
            }
            else
            {
                output.Text = "ERROR";
            }
            num1.Text = "";
            
            flag = 5;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            output.Text = "";
            num1.Text = "";
            num2.Text = "";
            outputLabel.Text = "";
            flag = 0;
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
