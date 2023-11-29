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
    public partial class PatientClinicalNotes : Form
    {
        string ConnectionString = "Data Source=DESKTOP-VQ4N64F\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
        public PatientClinicalNotes()
        {
            InitializeComponent();
        }

        private void PatientClinicalNotes_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Patient().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("Confirm password does not match with password");
            }
            else 
            {
                SqlConnection con = new(ConnectionString);

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT C.[Note ID],C.[Patient ID],C.[Note],C.[Follow-up Date] FROM [Clinical Notes] C, Patients P WHERE C.[Patient ID] = P.[Patient ID] and [User Name] = '" + textBox3.Text + "' and [Password] = '" + textBox1.Text + "' ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;

                con.Close();
            }
                            
        }
    }
}

