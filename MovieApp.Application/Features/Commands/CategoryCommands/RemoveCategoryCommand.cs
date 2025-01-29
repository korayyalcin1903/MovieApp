using AutoMapper;
using MediatR;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CategoryCommands
{
    public class RemoveCategoryCommand: IRequest<Guid>
    {
        public string Id { get; set; }

        public RemoveCategoryCommand(string id)
        {
            Id = id;
        }

        public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand, Guid>
        {
            private readonly ICategoryRepository _repository;
            private readonly IMapper _mapper;

            public RemoveCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }


            public async Task<Guid> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
            {
                var category = _mapper.Map<Category>(request);
                await _repository.DeleteAsync(category);
                return category.Id;
            }
        }
    }
}
