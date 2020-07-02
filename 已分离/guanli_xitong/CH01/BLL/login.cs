using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class login
    {
        DAL.login l = new DAL.login();
        public bool userlogin(Model.user u)
        {
            return l.select(u);
        }
        public bool zhuce(Model.user u)
        {
            return l.zhuce(u);
        }
        public bool update(Model.user u)
        {
            return l.update(u);
        }
    }
}
