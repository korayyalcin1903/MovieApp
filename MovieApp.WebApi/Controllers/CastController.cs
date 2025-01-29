using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.Commands.CastCommands;
using MovieApp.Application.Features.Queries.CastQueries;


namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCast()
        {
            var query = new GetAllCastQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCast(Guid id)
        {
            return Ok(await _mediator.Send(new GetByIdCastQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(UpdateCastCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMovie(RemoveCastCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
