using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.Commands.CategoryCommands;
using MovieApp.Application.Features.Queries.CategoryQueries;

namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<CreateCategoryCommand> _createValidator;
        private readonly IValidator<UpdateCategoryCommand> _updateValidator;

        public CategoryController(IMediator mediator, IValidator<CreateCategoryCommand> createValidator, IValidator<UpdateCategoryCommand> updateValidator)
        {
            _mediator = mediator;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var query = new GetAllCategoryQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCategory(Guid id)
        {
            return Ok(await _mediator.Send(new GetByIdCategoryQuery { Id = id }));
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
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
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
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
        public async Task<IActionResult> RemoveCategory(RemoveCategoryCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
