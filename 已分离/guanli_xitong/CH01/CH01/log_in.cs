using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CH01
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                         zhuce f3 = new zhuce();
                         f3.ShowDialog();         

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int pro = ProgressBar.Value;
            if (pro != 100)
            {

                this.statusStrip1.Visible = true;
                this.ProgressBar.Visible = true; 
                this.ProgressBar.Text = "登录中";
                this.ProgressBar.Value = this.ProgressBar.Value+4;
            }
            else
            {
         
                this.ProgressBar.Text = "就绪";
                timer1.Enabled = false;
                this.Hide();
               /* Form2 f2 = new Form2();
                f2.ShowDialog();
               */

                main m = new main();
                m.ShowDialog();
            
                this.ProgressBar.Value = 0;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Model.user u = new Model.user();

            u.username = textBox1.Text.Trim();
            u.password = textBox2.Text.Trim();

            BLL.login log = new BLL.login();



            if (log.userlogin(u))
            {
                timer1.Enabled = u.Timer1;
                MessageBox.Show("登录用户" + u.username);
            }
            else
            {
                MessageBox.Show("错误");
            }
            
        }

        private void toolStripProgressBar1_Click(object sender,EventArgs e)
        {
          
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        }
    }
