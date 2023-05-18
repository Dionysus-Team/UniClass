using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniClass.Domain.Features.Users
{
    public class Student
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _registration { get; set; }
        public string _cpf { get; set; }
        public string _password { get; set; }
        public string _class { get; set; }
        public string _email { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string registration, string cpf, string password, string @class, string email)
        {
            _id = id;
            _name = name;
            _registration = registration;
            _cpf = cpf;
            _password = password;
            _class = @class;
            _email = email;
        }
    }
}
