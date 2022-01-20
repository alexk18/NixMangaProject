using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        void PasswordChange(string newpass, string oldpass, int iduser);
        void AdressChange(string newadress, int iduser);
        void EmailChange(string newemail, int iduser);
    }
}
