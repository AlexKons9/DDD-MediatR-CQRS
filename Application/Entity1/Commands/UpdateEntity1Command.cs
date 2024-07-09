using Application.Entity1.Requests;
using MediatR;


namespace Application.Entity1.Commands
{
    public class UpdateEntity1Command(UpdateEntity1Request request) : IRequest
    {
        public UpdateEntity1Request Request { get; } = request;
    }
}
