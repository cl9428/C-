using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class yuangong
    {
        private string id;
        private string position;
        private string name;
        private string password;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
      
    
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
