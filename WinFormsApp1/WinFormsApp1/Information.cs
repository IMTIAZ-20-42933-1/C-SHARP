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
    public partial class Information : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";

        public Information()
        {
            InitializeComponent();
        }
        public void display()
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Hospital";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }
        private void Information_Load(object sender, EventArgs e)
        {
            display();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "INSERT INTO Hospital(NAME, ADDRESS, [E-MAIL], [PHONE NO.]) VALUES('"+textBox2.Text+"','"+textBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, con);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Successfully inserted");

            }
            else
            {
                MessageBox.Show("Check Again!");
            }

            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";     
            textBox6.Text = "";


            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();


            string sql = "Update Hospital set NAME = '"+textBox2.Text+"',ADDRESS = '"+textBox1.Text+"',[E-MAIL] = '"+textBox3.Text+"',[PHONE NO.] = '"+textBox4.Text+"' where ID = '"+int.Parse(textBox6.Text)+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Successfully updated.");

            }
            else
            {
                MessageBox.Show("Check Again!");
            }

            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

            display();
        }
    }
}
