using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Application.Features.Commands.MovieCommands;
using MovieApp.Application.Features.Queries.MovieQueries;

namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovie()
        {
            return Ok(await _mediator.Send(new GetAllMovieQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdMovie(string id)
        {
            return Ok(await _mediator.Send(new GetByIdCategoryQuery { Id = id}));
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetMovieByCategoryId(string categoryId)
        {
            return Ok(await _mediator.Send(new GetMovieByCategoryQuery(categoryId)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMovie(RemoveMovieCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
