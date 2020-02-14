using MediatR;

namespace GoBarber.Api.Domain.Users.Commands
{
    public class UpdateUserCommand : IRequest<string>
    {
        public string Name { get; protected set; }
        public string Password { get; protected set; }

        public UpdateUserCommand(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}