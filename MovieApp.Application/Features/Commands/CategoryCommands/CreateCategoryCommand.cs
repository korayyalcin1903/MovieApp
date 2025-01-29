using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CategoryDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public string? CategoryName { get; set; }
        public string? CategoryImgUrl { get; set; }

        public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
        {
            private readonly IMapper _mapper;
            private readonly ICategoryRepository _repository;
            public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
            {
                var category = _mapper.Map<Category>(request);
                await _repository.CreateAsync(category);
                return category.Id;
            }
        }
    }
}
