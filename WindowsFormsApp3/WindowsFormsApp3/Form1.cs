using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aksha\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\User.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "SELECT * FROM Student";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString());
                comboBox2.Items.Add(reader.GetValue(1).ToString());
                comboBox3.Items.Add(reader.GetValue(2).ToString());
            }
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Id";
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Name";
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "Gender";

            connection.Close();
        }
    

     

    }
}
