using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   
    public class yuangong
    {
        DAL.yuangong l = new DAL.yuangong();
        public bool add(Model.yuangong y)
        {
            return l.add(y);
        }
        public bool delete(Model.yuangong y)
        {
            return l.delete(y);
        }
    }
}
