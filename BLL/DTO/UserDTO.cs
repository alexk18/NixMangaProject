using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class UserDTO
    {
  
        public UserDTO ( int a, string b, string c, string d, string f)
        {
            UserId = a;
            Login = b;  
            Password = c;
            Adress = d;
            Email = f;
        }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
       // public Guid TrashboxId { get; set; }
    }
}
