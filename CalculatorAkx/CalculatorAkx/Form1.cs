using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAkx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double a;
        public double ans = 0;
        string Flag;
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (ans == 0)
                {
                    ans = double.Parse(textBox1.Text);
                }
                else
                {
                    a = double.Parse(textBox1.Text);
                    PerformLastOperation();
                }
                Flag = "+";
                textBox1.Clear();
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (ans == 0)
                {
                    ans = double.Parse(textBox1.Text);
                }
                else
                {
                    a = double.Parse(textBox1.Text);
                    PerformLastOperation();
                }
                Flag = "-";
                textBox1.Clear();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (ans == 0)
                {
                    ans = double.Parse(textBox1.Text);
                }
                else
                {
                    a = double.Parse(textBox1.Text);
                    PerformLastOperation();
                }
                Flag = "/";
                textBox1.Clear();
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (ans == 0)
                {
                    ans = double.Parse(textBox1.Text);
                }
                else
                {
                    a = double.Parse(textBox1.Text);
                    PerformLastOperation();
                }
                Flag = "*";
                textBox1.Clear();
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                PerformLastOperation();
                textBox1.Text = ans.ToString();
                Flag = "";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            ans = 0;
            a = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerformLastOperation()
        {
            switch (Flag)
            {
                case "+":
                    ans += a;
                    break;
                case "-":
                    ans -= a;
                    break;
                case "*":
                    ans *= a;
                    break;
                case "/":
                    if (a != 0) ans /= a;
                    break;
                case "%":
                    ans %= a;
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }
    }
}
