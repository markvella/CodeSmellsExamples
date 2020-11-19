using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace TemporaryField.Bad
{
    public class UserRegistration
    {
        private string _name;
        private string _email;
        private string _surname;

        public void Register(string name,string surname,string email)
        {
            _name = name;
            _email = email;
            _surname = surname;
            //...Save the user to database
        }

        public void SendEmail(string subject,string body)
        {
            var client = new SmtpClient();
            client.Send("admin@oursite.com", _email, "Welcome to oursite.com", $"Dear {_name}, Welcome to oursite.com");
        }
    }
}
