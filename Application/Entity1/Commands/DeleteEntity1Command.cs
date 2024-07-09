using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity1.Commands
{
    public class DeleteEntity1Command(string userId) : IRequest
    {
        public string UserId { get; } = userId;
    }
}
