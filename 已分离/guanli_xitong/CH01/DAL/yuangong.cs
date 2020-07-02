using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{ 
   
    public class yuangong
    {
        Model.yuangong y = new Model.yuangong();
        SqlConnection con = DB.getDB();
        public Boolean add(Model.yuangong y)
        {
            bool y1 = new bool();
            con.Open();
           
            SqlCommand com = new SqlCommand();
            com.CommandText = "insert into yuangong (工号,员工职位,员工姓名,密码) values('" + y.Id + "','" + y.Position+ "','" +y.Name + "','" + y.Password + "')";
             com = new SqlCommand(com.CommandText, con);//sqlcommand表示要向向数据库执行sql语句或存储过程
            int q = com.ExecuteNonQuery();//执行后返回记录行数

            if (q > 0)//如果大于0，说明记录存在
            {
                y1 = true;
            }
            else
            {
                y1 = false;
            }
            return y1;
        }
        public bool delete(Model.yuangong y)
        {
            bool y1 = new bool();
           
            con.Open();

            SqlCommand com = new SqlCommand();
            com.CommandText = "delete yuangong where 工号='" + y.Id + "'";
            com = new SqlCommand(com.CommandText, con);//sqlcommand表示要向向数据库执行sql语句或存储过程
            int q = com.ExecuteNonQuery();//执行后返回记录行数

            if (q > 0)//如果大于0，说明记录存在
            {
                y1 = true;
               
            }
            else
            {
                y1 = false;
            }
            con.Close();
            return y1;
        }
    }
}
