using Application.Entity1.Commands;
using AutoMapper;
using Domain.Repositories;
using MediatR;


namespace Application.Entity1.Handlers
{
    public class UpdateEntity1Handler(IEntity1Repository repository, IMapper mapper) : IRequestHandler<UpdateEntity1Command>
    {
        Task IRequestHandler<UpdateEntity1Command>.Handle(UpdateEntity1Command command, CancellationToken cancellationToken)
        {
            var userEntity = mapper.Map<Domain.Entities.Entity1>(command.Request);
            return repository.UpdateAsync(userEntity, cancellationToken);
        }
    }
}
