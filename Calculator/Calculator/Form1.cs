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
    public partial class formCalc : Form
    {
        private string input = string.Empty;
        private string InputOption1 = string.Empty;
        private string InputOption2 = string.Empty;
        private char operation;
        private double result = 0.0;
        
        public formCalc()
        {
            InitializeComponent();
        }

        private void formCalc_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.InputOption1 = string.Empty;
            this.InputOption2 = string.Empty;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.InputOption1 = string.Empty;
            this.InputOption2 = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = 's';
            input = string.Empty;
        }

        private void btnCubed_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = 'c';
            input = string.Empty;
        }

        private void btnToY_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = '^';
            input = string.Empty;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = 'q';
            //input = string.Empty;
        }

        private void btn1Over_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = 'z';
            //input = string.Empty;
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = 'x';
            //input = string.Empty;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "-";
            this.textBox1.Text += input;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            InputOption1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            InputOption2 = input;
            double num1, num2;
            double.TryParse(InputOption1, out num1);
            double.TryParse(InputOption2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "You Can't Divide By 0, Ya Dingle";
                }
            }
            else if (operation == '^')
            {
                result = Math.Pow(num1,num2);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'x')
            {
                result = num1 * 10;
                textBox1.Text = result.ToString();
            }
            else if (operation == 'z')
            {
                result = 1 / num1;
                textBox1.Text = result.ToString();
            }
            else if (operation == 'q')
            {
                result = Math.Sqrt(num1);
                textBox1.Text = result.ToString();
            }
            else if (operation == 's')
            {
                result = Math.Pow(num1,2);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'c')
            {
                result = Math.Pow(num1,3);
                textBox1.Text = result.ToString();
            }
        }
        
    }
}
