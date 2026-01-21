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

        private List<string> operators = new List<string> { "+", "-", "/", "*" };


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 7;
            string inputVal = textBox1.Text.Trim();

            string identifier = operators.FirstOrDefault(op => inputVal.Contains(op));

            var parts = inputVal.Split(new string[] { identifier }, StringSplitOptions.RemoveEmptyEntries);
            int newValue = Convert.ToInt32(parts);
            int result;

            switch (identifier)
            {
                case "+":
                    result = newValue + value;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    // Handle subtraction
                    break;
                case "*":
                    // Handle multiplication
                    break;
                case "/":
                    // Handle division
                    break;
                default:
                    int result = Convert.ToInt32(textBox1.Text) + value;
                    textBox1.Text = result.ToString();
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = 8;
            int result = Convert.ToInt32(textBox1.Text) + value;
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 9;
            int result = Convert.ToInt32(textBox1.Text) + value;
            textBox1.Text = result.ToString();
        }
    }
}
