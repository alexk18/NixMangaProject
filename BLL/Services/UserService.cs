using BLL.DTO;
using BLL.Interfaces;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        UserRepository userRepository = new UserRepository();
        public void AdressChange(string newadress, int iduser)
        {
            foreach (var user in userRepository.users)
            {
                if(iduser == user.UserId)
                {
                    user.Adress = newadress;
                }
            }
        }

        public void EmailChange(string newemail, int iduser)
        {
            foreach (var user in userRepository.users)
            {
                if (iduser == user.UserId)
                {
                    user.Email = newemail;
                }
            }
        }

        public void PasswordChange(string newpass, string oldpass, int iduser)
        {
            foreach (var user in userRepository.users)
            {
                if (iduser == user.UserId || user.Password == oldpass)
                {
                    user.Password = oldpass;
                }
            }
        }
    }
}
