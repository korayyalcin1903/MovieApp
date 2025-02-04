using FluentValidation;
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
        private readonly IValidator<CreateCommentCommand> _createValidator;
        private readonly IValidator<UpdateCommentCommand> _updateValidator;

        public CommentController(IMediator mediator, IValidator<CreateCommentCommand> createValidator, IValidator<UpdateCommentCommand> updateValidator)
        {
            _mediator = mediator;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
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
            var validationResult = await _createValidator.ValidateAsync(command);
            if (!validationResult.IsValid)
            {
                var errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
                return BadRequest(new { errors = errors });
            }
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(UpdateCommentCommand command)
        {
            var validationResult = await _updateValidator.ValidateAsync(command);
            if (!validationResult.IsValid)
            {
                var errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
                return BadRequest(new { errors = errors });
            }
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
