﻿using System;
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
    public partial class A_nr : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";

        public A_nr()
        {
            InitializeComponent();
        }

        public void display()
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Nurses";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "INSERT INTO Nurses([NURSE ID], [NAME], [SALARY], [JOINING DATE], [USERNAME]) VALUES('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "', '" + textBox7.Text + "')";
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
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            display();
        }

        private void A_nr_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "DELETE FROM Nurses WHERE [NURSE ID] = '" + int.Parse(textBox6.Text) + "'";
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

            textBox1.Text = "";

            display();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();


            string sql = "Update Nurses set NAME = '" + textBox1.Text + "', SALARY = '" + textBox4.Text + "', [JOINING DATE] = '" + DateTime.Parse(dateTimePicker1.Text) + "', USERNAME = '" + textBox7.Text + "' where [NURSE ID] = '" + int.Parse(textBox6.Text) + "' ";
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
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            display();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Nurses WHERE [NURSE ID] = '" + int.Parse(textBox5.Text) + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            textBox5.Text = "";
        }
    }
}
