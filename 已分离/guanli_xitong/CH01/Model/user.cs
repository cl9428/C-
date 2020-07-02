using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class user
    {
 

        private Boolean timer1;

        public Boolean Timer1
        {
            get { return timer1; }
            set { timer1 = value; }
        }

        private string 账号;
        private string 密码;

        public string username
        {
            get { return 账号; }
            set { 账号 = value; }
        }
        public string password
        {
            get { return 密码; }
            set { 密码 = value; }
        }

    }
}
