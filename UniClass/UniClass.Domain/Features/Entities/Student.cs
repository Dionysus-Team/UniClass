using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniClass.Domain.Features.Entities
{
    public class Student
    {
        private string _name { get; set; }
        private string _cpf { get; set; }
        private string _class { get; set; }
        private string _registration { get; set; }
        private string _email { get; set; }

        public Student()
        {

        }

        public Student(string name, string cpf, string @class, string registration, string email)
        {
            _name = name;
            _cpf = cpf;
            _class = @class;
            _registration = registration;
            _email = email;
        }
    }
}
