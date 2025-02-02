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

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
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
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
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
