using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class User
    {
        public string Login { get; set; }
        public string Hash { get; set; }
        public string Email { get; set; }
        public User(string login, string hash, string email)
        {
            Login = login;
            Hash = hash;
            Email = email;
        }
    }
}
