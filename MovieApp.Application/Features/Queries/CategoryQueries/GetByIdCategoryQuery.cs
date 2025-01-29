using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CategoryDtos;
using MovieApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Queries.CategoryQueries
{
    public class GetByIdCategoryQuery: IRequest<GetByIdCategoryDto>
    {
        public Guid Id { get; set; }
        public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, GetByIdCategoryDto>
        {
            private readonly IMapper _mapper;
            private readonly ICategoryRepository _repository;

            public GetByIdCategoryQueryHandler(IMapper mapper, ICategoryRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<GetByIdCategoryDto> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
            {
                var category = await _repository.GetByIdAsync(request.Id);
                return _mapper.Map<GetByIdCategoryDto>(category);
            }
        }
    }
}
