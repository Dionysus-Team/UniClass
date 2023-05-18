using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniClass.Domain.Features.Users
{
    public class Coordenation
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string password { get; set; }

        public Coordenation()
        {

        }

        public Coordenation(int id, string name, string password)
        {
            _id = id;
            _name = name;
            this.password = password;
        }
    }
}
