using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "SELECT [User Name],[Password] FROM Patients WHERE [User Name] = '" + textBox3.Text.Trim() + "' AND [Password] = '" + textBox1.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlDataReader rd = cmd.ExecuteReader();

            if (textBox3.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Fill both username and password");
            }
            else if (rd.HasRows == true)
            {
                new Patient().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox1.PasswordChar = '\0' ;
            }
            else
            {
                textBox1.PasswordChar = '*' ;
            }

            checkBox1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}