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
    public partial class yuangong : Form
    {
        Model.yuangong y = new Model.yuangong();
        BLL.yuangong by = new BLL.yuangong();

        public yuangong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jiudian_guanliDataSet1.yuangong”中。您可以根据需要移动或删除它。
            this.yuangongTableAdapter.Fill(this.jiudian_guanliDataSet1.yuangong);
        }

        private void butEntry_Click(object sender, EventArgs e)
        {
            y.Id = textBox1.Text;
            y.Position = textBox2.Text;
            y.Name = textBox3.Text;
            y.Password = textBox4.Text;
            if (y.Id == null || y.Position == null || y.Name == null || y.Password == null)
            {
                MessageBox.Show("数据不能为空");
            }
            else if(by.add(y))
            {
                MessageBox.Show("添加成功");
                // TODO: 这行代码将数据加载到表“jiudian_guanliDataSet1.yuangong”中。您可以根据需要移动或删除它。
                this.yuangongTableAdapter.Fill(this.jiudian_guanliDataSet1.yuangong);
            }else
            {
                MessageBox.Show("添加失败");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            y.Id = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            if (by.delete(y))
            {
                MessageBox.Show("删除成功");
                // TODO: 这行代码将数据加载到表“jiudian_guanliDataSet1.yuangong”中。您可以根据需要移动或删除它。
                this.yuangongTableAdapter.Fill(this.jiudian_guanliDataSet1.yuangong);
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
