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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LoginDoctor().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LoginNurse().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             new LoginOfficer().Show();
            this.Hide();
        }
    }
}
