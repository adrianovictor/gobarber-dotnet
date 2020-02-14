using System;
using GoBarber.Api.Domain.Common;

namespace GoBarber.Api.Domain.Users.Models
{
    public class User : Entity<User>
    {
        public Guid UniqueId { get; set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public bool Provider { get; protected set; }

        protected User() 
        {
            UniqueId = Guid.NewGuid();
        }

        public User(string name, string email, string password, bool provider)
        {
            Name = name;
            Email = email;
            Password = password;
            Provider = provider;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}