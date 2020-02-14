using System.Threading;
using System.Threading.Tasks;
using GoBarber.Api.Domain.Users.Commands;
using MediatR;

namespace GoBarber.Api.Domain.Users.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, string>
    {
        public Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}