using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_16.Models
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

        public User( string name, string surname, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }

        public override string ToString() //bir değişkenin değerini string türüne kolaylıkla dönüştürmemizi
                                          //sağlar. Bu metod sayesinde, sayısal verileri ve diğer veri
                                          //tiplerini string türüne dönüştürebiliriz. 
        {
            return $"{name} - {surname} - {email} - {password}";
        }

    }
}
