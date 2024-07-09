using Application.Entity1.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity1.Queries
{
    public class GetEntity1Query(string id, string prop2) : IRequest<Entity1Response>
    {
        public string Id { get; set; } = id;
        public string Prop2 { get; set; } = prop2;
    }
}
