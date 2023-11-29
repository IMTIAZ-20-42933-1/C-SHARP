using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new PatientProfile().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new PatientTest().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new PatientRooms().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new PatientMedicine().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new PatientPageInfo().Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new PatientClinicalNotes().Show();
            this.Hide();
        }
    }
}
