using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CH01
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void picReception_Click(object sender, EventArgs e)
        {
            guest g = new guest();
            g.ShowDialog();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            yuangong g = new yuangong();
            g.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            zhuce z = new zhuce();
            z.ShowDialog();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
