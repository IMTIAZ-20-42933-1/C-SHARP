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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Fill both username and password");
            }
            else if (textBox3.Text == "admin" && textBox1.Text == "admin")
            {
                this.Hide();
                new Form3().Show();
                
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
