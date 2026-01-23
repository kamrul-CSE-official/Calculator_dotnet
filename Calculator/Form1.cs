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
        public Form1()
        {
            InitializeComponent();
        }

        double firstValue;
        string operation;
        bool operationPressed = false;

        private void button_click(object sender, EventArgs e)
        {
            //Screen clean - 1
            if((textBox1.Text == "0") || (operationPressed))
                textBox1.Clear();

            operationPressed = false;

            //কোন বাটন থেকে ক্লিক করা হয়েছে তা বোঝার জন্য আমরা sender ব্যবহার করি - 2
            Button button = (Button)sender;

            //দশমিক হেন্ডেল করা - 3
            if (button.Text == ".")
            {
                //যদি আগে দশমিক থাকে সেটা চেক করা হবে -4
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void operator_check(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
        }

        private List<string> operators = new List<string> { "+", "-", "/", "*" };


        private void button7_Click(object sender, EventArgs e)
        {
            int value = 3;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string identifier = operators.FirstOrDefault(op => textBox1.Text.Contains(op));
            if(identifier == null ) textBox1.Text = textBox1.Text + "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 7;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);  
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;  
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = 8;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 9;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string identifier = operators.FirstOrDefault(op => textBox1.Text.Contains(op));
            if (identifier == null) textBox1.Text = textBox1.Text + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string identifier = operators.FirstOrDefault(op => textBox1.Text.Contains(op));
            if (identifier == null) textBox1.Text = textBox1.Text + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string identifier = operators.FirstOrDefault(op => textBox1.Text.Contains(op));
            if (identifier == null) textBox1.Text = textBox1.Text + "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int value = 4;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int value = 5;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = 6;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int value = 1;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int value = 2;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int value = 0;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            if (inputVal == "")
            {
                textBox1.Text = value.ToString();
                return;
            }

            if (identifier == null)
            {
                textBox1.Text = inputVal + value.ToString();
                return;
            }

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                textBox1.Text = inputVal;
                return;
            }
            int newValue = Convert.ToInt32(parts[0]);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = newValue - value;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = newValue * value;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (value == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                        return;
                    }
                    result = newValue / value;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = inputVal;
                    break;
            }
        }
    }
}
