using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.Commands.CommentCommands;
using MovieApp.Application.Features.Queries.CommentQueries;


namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComment()
        {
            var query = new GetAllCommentQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdComment(Guid id)
        {
            return Ok(await _mediator.Send(new GetByIdCommentQuery { Id = id }));
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(UpdateCommentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMovie(RemoveCommentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("Movie/{id}")]
        public async Task<IActionResult> GetCommentByMovie(string id)
        {
            return Ok(await _mediator.Send(new GetCommentByMovieIdQuery { Id = id }));
        }
    }
}
