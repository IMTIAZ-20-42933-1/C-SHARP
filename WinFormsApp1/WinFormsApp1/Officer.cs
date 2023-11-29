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
    public partial class Officer : Form
    {
        public Officer()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginOfficer().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new OfficerProfile().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Test().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Medicine().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Hide();
        }
    }
}
