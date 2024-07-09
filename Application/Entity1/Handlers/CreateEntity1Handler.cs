using Application.Entity1.Commands;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Entity1.Handlers
{
    public class CreateEntity1Handler(IEntity1Repository repository, IMapper mapper) : IRequestHandler<CreateEntity1Command>
    {
        public Task Handle(CreateEntity1Command command, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Domain.Entities.Entity1>(command.Request);
            return repository.CreateAsync(entity, cancellationToken);
        }
    }
}
