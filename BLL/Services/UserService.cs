using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        List<UserDTO> users = new List<UserDTO>()
        {
            new UserDTO(1, "Login", "Password", "adess", "email"),
            new UserDTO(2, "Login", "Password", "adess", "email"),
            new UserDTO(3, "Login", "Password", "adess", "email")
        };
        public void AdressChange(string newadress, int iduser)
        {
            foreach (var user in users)
            {
                if(iduser == user.UserId)
                {
                    user.Adress = newadress;
                }
            }
        }

        public void EmailChange(string newemail, int iduser)
        {
            foreach (var user in users)
            {
                if (iduser == user.UserId)
                {
                    user.Email = newemail;
                }
            }
        }

        public void PasswordChange(string newpass, string oldpass, int iduser)
        {
            foreach (var user in users)
            {
                if (iduser == user.UserId || user.Password == oldpass)
                {
                    user.Password = oldpass;
                }
            }
        }
    }
}
