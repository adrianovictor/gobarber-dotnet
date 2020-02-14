using System.Threading;
using System.Threading.Tasks;
using GoBarber.Api.Domain.Users.Commands;
using MediatR;

namespace GoBarber.Api.Domain.Users.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, string>
    {
        public Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}