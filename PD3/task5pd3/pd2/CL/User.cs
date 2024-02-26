using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd2.CL
{
    internal class User
    {
        public string name;
        public string id;
        public string password;
        public User(string sname,string ids,string pass ) 
        {
            this.name = sname;
            this.id = ids;
            this.password = pass;
        }
    }
}
