using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniClass.Domain.Features.Users
{
    public class Admin
    {
        private int _id { get; set; }

        private string _name { get; set; }
        private string _password { get; set; }
        public Admin()
        {

        }

        public Admin(int id, string name, string password)
        {
            _id = id;
            _name = name;
            _password = password;
        }
    }
}
