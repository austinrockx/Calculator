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
        private void Num0_click_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void Num1_click_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void Num2_click_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void Num3_click_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void Num4_click_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void Num5_click_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void Num6_click_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Num7_click_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void Num8_click_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void Num9_click_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (!Output.Text.Contains("."))
            {
                Output.Text += ".";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Text = string.Empty;
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Output.Text += "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Output.Text += "/";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Output.Text += "-";
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(Output.Text);
                Output.Text = (Math.Pow(num, 2)).ToString();
            }
            catch (FormatException)
            {
                Output.Text = "Invalid Input";
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(Output.Text);
                if (num >= 0)
                {
                    Output.Text = (Math.Sqrt(num)).ToString();
                }
                else
                {
                    Output.Text = "Invalid Input";
                }
            }
            catch (FormatException)
            {
                Output.Text = "Invalid Input";
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = new DataTable().Compute(Output.Text, null).ToString();
            }
            catch (Exception)
            {
                Output.Text = "Error";
            }
        }
    }
}
