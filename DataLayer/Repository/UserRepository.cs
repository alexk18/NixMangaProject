using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class UserRepository
    {
        public List<User> users = new List<User>()
        {
            new User(1, "Login", "Password", "adess", "email"),
            new User(2, "Login", "Password", "adess", "email"),
            new User(3, "Login", "Password", "adess", "email")
        };
    }
}
