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
    public partial class zhuce : Form
    {

        Model.user u = new Model.user();
        BLL.login l = new BLL.login();

        public zhuce()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
          
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            u.password = textBox2.Text.Trim();
            u.username = textBox1.Text.Trim();
            string a = textBox3.Text.Trim();

               if (a==null||u.username==null||u.password==null)
            {
                 MessageBox.Show("数据不能为空");
            }
           
               else if (u.password != a)
           {
               MessageBox.Show("密码不一致");

           }
            else if(l.zhuce(u))
            {
                MessageBox.Show("注册成功");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
