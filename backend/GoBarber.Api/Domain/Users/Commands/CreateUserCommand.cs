using MediatR;

namespace GoBarber.Api.Domain.Users.Commands
{
    public class CreateUserCommand : IRequest<string>
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public bool Provider { get; protected set; }

        public CreateUserCommand(string name, string email, string password, bool provider)
        {
            Name = name;
            Email = email;
            Password = password;
            Provider = provider;
        }
    }
}