using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class DB
    {
        public static SqlConnection getDB()
        {
        
        String c= " Data Source=.;Initial Catalog=jiudian_guanli;User ID=sa;Password=123456";//连接字符串                    
        SqlConnection con = new SqlConnection(c);
           

        return con;
        }
    }
    public class login
    {
        SqlConnection con = DB.getDB();

        public Boolean select(Model.user u)
        {
            con.Open();//打开连接
            string sql = string.Format("select count(*) from user1 where 账号='{0}' and 密码='{1}'", u.username, u.password);//查询是否有该条记录，根据账户密码
            SqlCommand command = new SqlCommand(sql, con);//sqlcommand表示要向向数据库执行sql语句或存储过程
            int i = Convert.ToInt32(command.ExecuteScalar());//执行后返回记录行数

            if (i > 0)//如果大于1，说明记录存在，登录成功
            {

                u.Timer1 = true;

            }
            else
            {
                u.Timer1 = false;
            }
                con.Close();

            return u.Timer1;       
        }
        public Boolean zhuce(Model.user u)
        {
            bool q=new bool();
            //注册
            try
            {
                con.Open();//打开连接
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "insert into user1(账号,密码) values ('" + u.username + "','" + u.password+ "')";
                if (com.ExecuteNonQuery() != 0)
                   q= true;
                else
                {
                    q= false;
                }

            }
            catch (Exception e)
            {

                System.Console.Write("错误"+e);

            }
            finally
            {
                con.Close();

            }
            return q;
        }

        public bool update(Model.user u)
        {
            bool u1;
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "update user1 set 密码='" + u.password+ "' where 账号='" + u.username + "'";
                if (com.ExecuteNonQuery() != 0)
                {
                    System.Console.Write("成功");
                    u1 = true;
                    con.Close();
                }
                else
                {
                    System.Console.Write("错误");
                    u1 = false;
                }
                return u1;
            
        }
    }
}
