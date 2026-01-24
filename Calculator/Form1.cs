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

     

        private void button10_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox2.Text = (firstValue + Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                case "-":
                    textBox2.Text = (firstValue - Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                case "*":
                    textBox2.Text = (firstValue * Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                case "/":
                    if (Convert.ToDouble(textBox2.Text) == 0)
                    {
                        textBox2.Text = "Error: Division by zero";
                        return;
                    }
                    textBox2.Text = (firstValue / Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                default:
                    break;

            }

            // ২. চেইন ক্যালকুলেশনের জন্য প্রস্তুতি
            // রেজাল্ট বের হওয়ার পর সেই রেজাল্টটিকেই আবার resultValue তে রাখা হয়
            // যাতে এরপর আবার কোনো যোগ-বিয়োগ করলে এই রেজাল্টের সাথে হয়।

            Double temp;
            if(Double.TryParse(textBox2.Text, out temp))
            {
                firstValue = temp;
            }
            else
            {
                firstValue = 0;
            }

        }

        private void operator_check(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(firstValue != 0)
            {
                //(টানা অংকের জন্য)
                button10.PerformClick();
                operation = button.Text;
                operationPressed = true;

            }
            else
            {
                operation = button.Text;
                firstValue = Convert.ToDouble(textBox2.Text);
                operationPressed = true;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
