using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public string DateOfBirth;
        public bool IsSingle;
        public Post[] Posts;

        public User(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public User(string name, string surname, string dateofbirth) : this(name, surname)
        {
            DateOfBirth = dateofbirth;
        }
        public User(string name, string surname, string dateofbirth, string email, bool issingle) : this(name, surname, dateofbirth)
        {
            Email = email;
            IsSingle = issingle;
        }
    }
}
