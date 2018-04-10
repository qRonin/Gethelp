using System;

namespace Gethelp.Models
{
    public class User
    {
        public Guid Id {get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }



        protected User()
        {

        }

        public User(string username, string password, Guid id, string salt) {
            Id = id;
            Username = username;
            Password = password;
            Salt = salt;

            }
    }


}