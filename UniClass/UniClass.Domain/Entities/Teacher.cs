using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniClass.Domain.Entities
{
    public class Teacher
    {
        private string _name { get; set; }
        private string _cpf { get; set; }
        private string _class { get; set; }
        private string _email { get; set; }

        public Teacher()
        {

        }

        public Teacher(string name, string cpf, string @class, string email)
        {
            _name = name;
            _cpf = cpf;
            _class = @class;
            _email = email;
        }
    }
}
