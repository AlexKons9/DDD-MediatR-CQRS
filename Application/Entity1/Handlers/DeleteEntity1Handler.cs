using Application.Entity1.Commands;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity1.Handlers
{
    public class DeleteEntity1Handler(IEntity1Repository repository) : IRequestHandler<DeleteEntity1Command>
    {
        public Task Handle(DeleteEntity1Command command, CancellationToken cancellationToken) =>
            repository.DeleteAsync(command.UserId, cancellationToken);
    }
}
