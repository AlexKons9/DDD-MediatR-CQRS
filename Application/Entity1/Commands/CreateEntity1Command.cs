using Application.Entity1.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity1.Commands
{
    public class CreateEntity1Command(CreateEntity1Request request) : IRequest
    {
        public CreateEntity1Request Request { get; } = request;
    }
}
