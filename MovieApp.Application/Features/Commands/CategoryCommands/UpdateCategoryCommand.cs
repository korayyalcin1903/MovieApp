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
    public class UpdateCategoryCommand: IRequest<UpdateCategoryDto>
    {
        public string? Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryImgUrl { get; set; }
        public class UpdateMovieCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryDto>
        {
            private readonly IMapper _mapper;
            private readonly ICategoryRepository _repository;

            public UpdateMovieCommandHandler(ICategoryRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<UpdateCategoryDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
            {
                var category = _mapper.Map<Category>(request);
                await _repository.UpdateAsync(category);
                return _mapper.Map<UpdateCategoryDto>(category);
            }
        }
    }
}
