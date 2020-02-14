using GoBarber.Api.Domain.Common;

namespace GoBarber.Api.Domain.Users.Models
{
    public class User : Entity<User>
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public bool Provider { get; protected set; }

        protected User() { }

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