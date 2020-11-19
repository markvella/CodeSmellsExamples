using System;

namespace PrimitiveObsession.Wrong
{
    public class User
    {
        public bool CreateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException(nameof(username));
            }

            if (string.IsNullOrEmpty(password) || password.Length<8)
            {
                throw new ArgumentException(nameof(password));
            }

            return true;
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException(nameof(username));
            }

            if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 8)
            {
                throw new ArgumentException(nameof(newPassword));
            }
            return oldPassword.Equals(newPassword);
        }
    }
}
