using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prac7inheritance
{
    public partial class Form2 : prac7inheritance.Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Derived Form1 Submit: " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            MessageBox.Show("Input CLeared");
        }
    }
}
