using MediatR;

namespace GoBarber.Api.Domain.Users.Commands
{
    public class DeleteUserCommand : IRequest<string>
    {
        public int Id { get; protected set; }

        public DeleteUserCommand(int id)
        {
            Id = id;
        }
    }
}