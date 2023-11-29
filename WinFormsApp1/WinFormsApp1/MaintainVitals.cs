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
    public partial class MaintainVitals : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";

        public MaintainVitals()
        {
            InitializeComponent();
        }
        public void display()
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Vitals";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;

            con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "INSERT INTO Vitals([Patient ID],[B/P],[Temperature],[Weight],[Sugar],[Date]) VALUES('" + int.Parse(textBox3.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '"+dateTimePicker1.Text+"')";
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
            textBox5.Text = "";

            display();
        }

        private void MaintainVitals_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "DELETE FROM Vitals WHERE [Vital ID] = '" + int.Parse(textBox7.Text) + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Successfully deleted.");

            }
            else
            {
                MessageBox.Show("Check Again!");
            }

            con.Close();

            textBox7.Text = "";

            display();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();


            string sql = "Update Vitals set [Patient ID] = '" + textBox3.Text + "', [B/P] = '" + textBox1.Text + "', [Temperature] = '" + textBox2.Text + "', [Weight] = '" + textBox4.Text + "', [Sugar] = '" + textBox5.Text + "', [Date] = '" + DateTime.Parse(dateTimePicker1.Text) + "' where [Vital ID] = '" + int.Parse(textBox7.Text) + "' ";
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
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
          

            display();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Vitals WHERE [Vital ID] = '" + int.Parse(textBox6.Text) + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;

            con.Close();

            textBox6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Nurse().Show();
            this.Hide();
        }
    }
}
