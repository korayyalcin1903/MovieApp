using Azure.Core;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Application.Features.Commands.MovieCommands;
using MovieApp.Application.Features.Queries.MovieQueries;
using MovieApp.Application.Validators;
using System.Threading;

namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<CreateMovieCommand> _createValidator;
        private readonly IValidator<UpdateMovieCommand> _updateValidator;
        public MovieController(IMediator mediator, IValidator<CreateMovieCommand> createValidator, IValidator<UpdateMovieCommand> updateValidator)
        {
            _mediator = mediator;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
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

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
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
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
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
        public async Task<IActionResult> RemoveMovie(RemoveMovieCommand command)
        {
            return Ok(await _mediator.Send(command));
        }


    }
}
