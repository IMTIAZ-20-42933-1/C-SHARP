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
    public partial class Rooms : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
        public Rooms()
        {
            InitializeComponent();
        }
        public void display()
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Rooms";
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

        private void Rooms_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Officer().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "INSERT INTO Rooms([Room Type],[Cost],[Available]) VALUES('" + textBox3.Text + "', '" + int.Parse(textBox1.Text) + "', '" + textBox2.Text + "')";
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

            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            string sql = "DELETE FROM Rooms WHERE [Room ID] = '" + int.Parse(textBox7.Text) + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();


            string sql = "Update Rooms set [Room Type] = '" + textBox3.Text + "', [Cost] = '" + textBox1.Text + "', [Available] = '" + textBox2.Text + "' where [Room ID] = '" + int.Parse(textBox7.Text) + "' ";
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
            textBox6.Text = "";
            textBox7.Text = "";


            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(ConnectionString);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Rooms WHERE [Room ID] = '" + int.Parse(textBox6.Text) + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;

            con.Close();
        }
    }
}
