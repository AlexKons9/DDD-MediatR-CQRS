using Application.Entity1.Queries;
using Application.Entity1.Responses;
using AutoMapper;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity1.Handlers
{
    public class GetEntity1Handler(IEntity1Repository repository, IMapper mapper) : IRequestHandler<GetEntity1Query, Entity1Response>
    {
        public async Task<Entity1Response> Handle(GetEntity1Query request, CancellationToken cancellationToken)
        {
            var entity1 = await repository.GetByIdAsync(request.Id);
            var response = mapper.Map<Entity1Response>(entity1);
            return response; 
        }
    }
}
