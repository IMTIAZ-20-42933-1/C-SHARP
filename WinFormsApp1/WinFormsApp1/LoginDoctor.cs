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
    public partial class LoginDoctor : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
        public LoginDoctor()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "SELECT [USERNAME],[PASSWORD] FROM Doctors WHERE [USERNAME] = '" + textBox3.Text.Trim() + "' AND [PASSWORD] = '" + int.Parse(textBox1.Text.Trim()) + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlDataReader rd = cmd.ExecuteReader();

            if (textBox3.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Fill both username and password");
            }
            else if (rd.HasRows == true)
            {
                new Doctor().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
