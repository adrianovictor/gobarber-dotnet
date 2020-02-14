using System.Threading;
using System.Threading.Tasks;
using GoBarber.Api.Domain.Users.Commands;
using MediatR;

namespace GoBarber.Api.Domain.Users.Handlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, string>
    {
        public Task<string> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}