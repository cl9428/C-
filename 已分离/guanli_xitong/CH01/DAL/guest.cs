using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class guest
    {
        SqlConnection con = DB.getDB();
        public SqlDataReader select(Model.guest g)
        {
              
                con.ConnectionString = "Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";
                con.Open();
                // com.CommandText = "select * from guest where 姓名='" + textBox2.Text + "' or 房号='" + textBox1.Text + "' or  性别='" + textBox3.Text + "' or 身份证号='" + textBox4.Text + "'";

                string sql = "select * from guest where 姓名='" + g.Name + "' or 房号='" + g.Hostid + "' or  性别='" + g.Sex + "' or 身份证号='" + g.SF_ID1 + "'";//查询是否有该条记录
                SqlCommand com = new SqlCommand(sql, con);//sqlcommand表示要向向数据库执行sql语句或存储过程
                g.Q = Convert.ToInt32(com.ExecuteScalar());//执行后返回记录行数
                SqlDataReader dr = com.ExecuteReader();
                con.Close();
                return dr;

        }
    }
}
