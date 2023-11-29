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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           // panel2.BackColor = Color.FromArgb(95, 0, 0, 0);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Must enter name");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Must enter user name");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Must enter password");
            }
            else if (textBox14.Text == "")
            {
                MessageBox.Show("Must re enter password");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Must choose date of birth");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Must choose blood group");
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Must choose gender");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Must enter phone number");
            }
            else if (textBox11.Text == "")
            {
                MessageBox.Show("Must enter email");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("Must enter address");
            }
            else if (textBox3.Text != textBox14.Text)
            {
                MessageBox.Show("Confirm password does not match with password");
            }
            else
            {
               
                    string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";

                    SqlConnection con = new(ConnectionString);

                    con.Open();


                string sql = "INSERT INTO Patients([Full Name], [User Name], [Password], [Date of Birth], [Blood Group], [Phone NO.], [E-Mail], [Address], [Gender]) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox9.Text + "','" + comboBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(sql,con);
                    int result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    MessageBox.Show("Successfully signed up.");

                }
                  else
                {
                    MessageBox.Show("Check Again!");
                }

                con.Close();


            }

        }

        
    }
}
