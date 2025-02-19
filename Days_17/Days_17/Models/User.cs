using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_17.Models
{
    public class User
    {
        private string name;
        private string surname;
        private string email;
        private string password;

        public string Name { set { name = value; } get { return name; } }
        public string Surname { set { surname = value; } get { return name; } }
        public string Email { set { email = value; } get { return name; } }
        public string Password { set { password = value; } get { return name; } }

        public User(string name, string surname, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return $"{name} - {surname} - {email} - {password}";
        }
    }
}
