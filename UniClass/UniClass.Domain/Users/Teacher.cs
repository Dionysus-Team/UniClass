using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniClass.Domain.Users
{
    public class Teacher
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _cpf { get; set; }
        public string _password { get; set; }
        public string _class { get; set; }
        public string _email { get; set; }
        public Teacher()
        {

        }

        public Teacher(int id, string name, string cpf, string password, string @class, string email)
        {
            _id = id;
            _name = name;
            _cpf = cpf;
            _password = password;
            _class = @class;
            _email = email;
        }
    }
}
