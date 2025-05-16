using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac7inheritance
{
    public partial class Form1 : Form
    {
        protected TextBox textBoxName;
        protected Button btnSubmit;
        public Form1()
        {
            InitializeComponent();
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"BaseForm Submit: Hello,{textBox1.Text}");
        }

        protected virtual void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
