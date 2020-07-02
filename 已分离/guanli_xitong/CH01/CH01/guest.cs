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
    public partial class guest : Form
    {
        SqlCommand com=new SqlCommand();
        Model.guest g = new Model.guest();
        BLL.guest bg=new BLL.guest();
        public guest()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void sx()
        {
            //刷新
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select * from guest";

                SqlDataReader dr = com.ExecuteReader();
                listView1.Columns.Clear();
                listView1.Clear();

                listView1.Columns.Add("记录", 60, HorizontalAlignment.Center);
                listView1.Columns.Add("房号", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("姓名", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("性别", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("身份证号", 200, HorizontalAlignment.Center);


                /*
                ColumnHeader [] t=new  ColumnHeader[4];
                t[0] = new ColumnHeader();

                t[1] = new ColumnHeader();
                t[1].Text = "编号";
                t[2] = new ColumnHeader();
                t[3] = new ColumnHeader();
                listView1.Columns.AddRange(t);
                 * */
                //  int i = 1;

                while (dr.Read())
                {

                    ListViewItem ls = new ListViewItem();
                    //  ls.Text = "第" + i + "条记录";
                    ls.SubItems.Add(dr[0].ToString());
                    ls.SubItems.Add(dr[1].ToString());
                    ls.SubItems.Add(dr[2].ToString());
                    ls.SubItems.Add(dr[3].ToString());
                    listView1.Items.Add(ls);
                    listView1.View = View.Details;
                    // i = i + 1;

                }

            }
            catch (Exception)
            {

                MessageBox.Show("连接失败");
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Hostid = textBox1.Text;
            g.Name = textBox2.Text;
            g.Sex = textBox3.Text;
            g.SF_ID1 = textBox4.Text;
            bg.select(g);

            //查询
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";
                con.Open();
                // com.CommandText = "select * from guest where 姓名='" + textBox2.Text + "' or 房号='" + textBox1.Text + "' or  性别='" + textBox3.Text + "' or 身份证号='" + textBox4.Text + "'";

                string sql = "select * from guest where 姓名='" + g.Name + "' or 房号='" +g.Hostid + "' or  性别='" +g.Sex + "' or 身份证号='" +g.SF_ID1 + "'";//查询是否有该条记录
                SqlCommand com = new SqlCommand(sql, con);//sqlcommand表示要向向数据库执行sql语句或存储过程
                g.Q = Convert.ToInt32(com.ExecuteScalar());//执行后返回记录行数
               

                if (g.Q > 0)//如果大于1，说明记录存在，登录成功
                {
                    SqlDataReader dr = com.ExecuteReader();
                    listView1.Columns.Clear();
                    listView1.Clear();

                    listView1.Columns.Add("记录", 60, HorizontalAlignment.Center);
                    listView1.Columns.Add("房号", 80, HorizontalAlignment.Center);
                    listView1.Columns.Add("姓名", 80, HorizontalAlignment.Center);
                    listView1.Columns.Add("性别", 80, HorizontalAlignment.Center);
                    listView1.Columns.Add("身份证号", 200, HorizontalAlignment.Center);


                    /*
                    ColumnHeader [] t=new  ColumnHeader[4];
                    t[0] = new ColumnHeader();

                    t[1] = new ColumnHeader();
                    t[1].Text = "编号";
                    t[2] = new ColumnHeader();
                    t[3] = new ColumnHeader();
                    listView1.Columns.AddRange(t);
                     * */
                    int i = 1;

                    while (dr.Read())
                    {

                        ListViewItem ls = new ListViewItem();
                        ls.Text = "第" + i + "条";
                        ls.SubItems.Add(dr[0].ToString());
                        ls.SubItems.Add(dr[1].ToString());
                        ls.SubItems.Add(dr[2].ToString());
                        ls.SubItems.Add(dr[3].ToString());
                        listView1.Items.Add(ls);
                        listView1.View = View.Details;
                        i = i + 1;

                    }

                }
                else
                {
                    MessageBox.Show("请正确输入");
                    sx();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("连接失败");
            }
            finally
            {
                con.Close();
            }

             }

             private void guest_Load(object sender, EventArgs e)
             {
                 g.Hostid = textBox1.Text;
                 g.Name = textBox2.Text;
                 g.Sex = textBox3.Text;
                 g.SF_ID1 = textBox4.Text;
                 //刷新
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select * from guest";

                SqlDataReader dr = com.ExecuteReader();
                listView1.Columns.Clear();
                listView1.Clear();

                listView1.Columns.Add("记录", 60, HorizontalAlignment.Center);
                listView1.Columns.Add("房号", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("姓名", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("性别", 80, HorizontalAlignment.Center);
                listView1.Columns.Add("身份证号", 200, HorizontalAlignment.Center);


                /*
                ColumnHeader [] t=new  ColumnHeader[4];
                t[0] = new ColumnHeader();

                t[1] = new ColumnHeader();
                t[1].Text = "编号";
                t[2] = new ColumnHeader();
                t[3] = new ColumnHeader();
                listView1.Columns.AddRange(t);
                 * */
                //  int i = 1;

                while (dr.Read())
                {

                    ListViewItem ls = new ListViewItem();
                    //  ls.Text = "第" + i + "条记录";
                    ls.SubItems.Add(dr[0].ToString());
                    ls.SubItems.Add(dr[1].ToString());
                    ls.SubItems.Add(dr[2].ToString());
                    ls.SubItems.Add(dr[3].ToString());
                    listView1.Items.Add(ls);
                    listView1.View = View.Details;
                    // i = i + 1;

                }

            }
            catch (Exception)
            {

                MessageBox.Show("连接失败");
            }
            finally
            {
                con.Close();
            }
                 //MessageBox.Show("如有疑问请咨询-致电15835120718");
             }

             private void button3_Click(object sender, EventArgs e)
             {
                 //添加
                 SqlConnection con = new SqlConnection();
                 try
                 {

                     con.ConnectionString = " Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";
                     // con.ConnectionString = "Data Source=.;Initial Catalog=test;Integrated Security=True";
                     con.Open();
                     SqlCommand com = new SqlCommand();
                     com.Connection = con;
                     //com.CommandText = "update guest set 姓名='" + textBox3.Text.Trim() + "' where 房号='" + textBox1.Text.Trim() + "'";
                     // com.CommandText = "delete from student where id='"+listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim()+"'";
                     com.CommandText = "insert into guest (房号,姓名,性别,身份证号) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                     if (com.ExecuteNonQuery() != 0)
                         MessageBox.Show("添加成功");
                     else
                     {
                         MessageBox.Show("添加失败");

                     }

                 }
                 catch (Exception)
                 {

                     MessageBox.Show("操作失败");

                 }
                 finally
                 {
                     con.Close();

                 }
                 sx();
             }

             private void button4_Click(object sender, EventArgs e)
             {
                 //删除
                 SqlConnection con = new SqlConnection();
                 try
                 {

                     con.ConnectionString = " Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";
                     // con.ConnectionString = "Data Source=.;Initial Catalog=test;Integrated Security=True";
                     con.Open();
                     SqlCommand com = new SqlCommand();
                     com.Connection = con;
                     //com.CommandText = "update guest set 姓名='" + textBox3.Text.Trim() + "' where 房号='" + textBox1.Text.Trim() + "'";
                     com.CommandText = "delete from guest where 房号='" + textBox1.Text + "'";
                     //com.CommandText = "insert into guest (房号,姓名,性别,身份证号) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                     if (com.ExecuteNonQuery() != 0)
                         MessageBox.Show("删除成功");
                     else
                     {
                         MessageBox.Show("删除失败");

                     }

                 }
                 catch (Exception)
                 {

                     MessageBox.Show("操作失败");

                 }
                 finally
                 {
                     con.Close();

                 }
                 sx();
             }

             private void listView1_SelectedIndexChanged(object sender, EventArgs e)
             {

             }

             private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
             {

             }

             private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
             {

             }

             private void toolStripComboBox1_Click(object sender, EventArgs e)
             {

             }

             private void toolStripButton1_Click(object sender, EventArgs e)
             {
               // f.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath("1.jpg"));
                 //this.BackgroundImage = Image.f("文件路径.jpg");

               //  this.BackgroundImage = Image.FromFile(@"C:\Users\常亮\Desktop\未分离\guanli_xitong\CH01\CH01\bin\Debug\Properties\Resources.resx\Logo.png");
                 ///this.Size = BackgroundImage.Size;
                 this.BackColor = Color.Blue;
             }

             private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
             {

             }
    }
   
}
