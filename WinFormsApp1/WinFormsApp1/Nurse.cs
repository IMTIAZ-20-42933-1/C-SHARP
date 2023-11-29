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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginNurse().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new NurseProfile().Show();  
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new MaintainVitals().Show();
            this.Hide();
        }
    }
}
