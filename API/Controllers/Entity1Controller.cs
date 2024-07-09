using Application.Entity1.Commands;
using Application.Entity1.Queries;
using Application.Entity1.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/entity1")]
    [ApiController]
    public class Entity1Controller(IMediator mediator) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id, string prop2, CancellationToken cancellationToken)
        {
            try
            {
                var response = await mediator.Send(new GetEntity1Query(id, prop2), cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest,
                               detail: $"{ex.Message}",
                               title: "Failed to get entity",
                               instance: $"/api/entity1/{id}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEntity1Request request, CancellationToken cancellationToken)
        {
            try
            {
                await mediator.Send(new CreateEntity1Command(request), cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest,
                               detail: $"{ex.Message}",
                               title: "Failed to create entity1",
                               instance: $"/api/entity1");
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateEntity1Request request, CancellationToken cancellationToken)
        {
            try
            {
                await mediator.Send(new UpdateEntity1Command(request), cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest,
                               detail: $"{ex.Message}",
                               title: "Failed to update entity1",
                               instance: $"/api/entity1");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Update(string id, CancellationToken cancellationToken)
        {
            try
            {
                await mediator.Send(new DeleteEntity1Command(id), cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest,
                               detail: $"{ex.Message}",
                               title: "Failed to delete entity1",
                               instance: $"/api/entity1/{id}");
            }
        }
    }
}
