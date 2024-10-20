using System;
using System.Windows.Forms;

namespace expt10
{
    public partial class Form1 : Form
    {
        int num1, num2;
        int operation;  // To store the operation: 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        // Add operation
        private void button11_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            operation = 1;  // Set operation to addition
        }

        // Subtract operation
        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            operation = 2;  // Set operation to subtraction
        }

        // Multiply operation
        private void button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            operation = 3;  // Set operation to multiplication
        }

        // Divide operation
        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            operation = 4;  // Set operation to division
        }

        // Equal button (calculate the result)
        private void button15_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);

            switch (operation)
            {
                case 1:
                    textBox1.Text = (num1 + num2).ToString();  // Addition
                    break;
                case 2:
                    textBox1.Text = (num1 - num2).ToString();  // Subtraction
                    break;
                case 3:
                    textBox1.Text = (num1 * num2).ToString();  // Multiplication
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        textBox1.Text = (num1 / num2).ToString();  // Division
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                    }
                    break;
                default:
                    textBox1.Clear();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
    }
}
