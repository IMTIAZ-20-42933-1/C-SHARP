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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new A_dr().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new A_nr().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new A_off().Show();
            this.Hide();
            
        }
        private void label5_Click(object sender, EventArgs e)
        {
            new A_pat().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Information().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
