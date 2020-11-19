using System;
using System.Collections.Generic;
using System.Text;

namespace PrimitiveObsession.Better
{
    public class User
    {
        public bool CreateUser(Username username, Password password)
        {
            return true;
        }

        public bool ChangePassword(Username username, Password oldPassword, Password newPassword)
        {
            return oldPassword.Equals(newPassword);
        }
    }
}
