namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        String name, email, gender, hobby, branch, sem;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            List<string> hbb = new List<string>();
            if (checkBox1.Checked)
            {
                hbb.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                hbb.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                hbb.Add(checkBox3.Text);
            }
            hobby = string.Join(", ", hbb);
            sem = listBox1.SelectedItem.ToString();

            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label11.Text = hobby;
            label12.Text = sem;
            label13.Text = gender;
            label14.Text = branch;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            branch = comboBox2.SelectedItem.ToString(); 
        }
    }
}
