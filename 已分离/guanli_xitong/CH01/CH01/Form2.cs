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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
           
   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = textBox3.Text;
            Model.user u= new Model.user();
            BLL.login l = new BLL.login();
            u.username = textBox1.Text;
            u.password = textBox2.Text;
            if(u.password!=c)
            {
                MessageBox.Show("两次输入不一致！！！");
            }
            else if (l.update(u))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_in l = new log_in();
            l.ShowDialog();
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
