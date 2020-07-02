using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BLL
{
    public class guest
    {
            DAL.guest dg = new DAL.guest();
        public SqlDataReader select(Model.guest g)
        {
            return dg.select(g);
        }
    }
}
