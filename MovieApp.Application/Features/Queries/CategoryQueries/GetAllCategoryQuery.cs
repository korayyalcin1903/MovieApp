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
    public class GetAllCategoryQuery: IRequest<List<GetAllCategoryDto>>
    {
        public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<GetAllCategoryDto>>
        {
            private readonly IMapper _mapper;
            private readonly ICategoryRepository _repository;

            public GetAllCategoryQueryHandler(IMapper mapper, ICategoryRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<List<GetAllCategoryDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
            {
                var categories = await _repository.GetAllAsync();
                var result = _mapper.Map<List<GetAllCategoryDto>>(categories);
                return result;
            }
        }
    }
}
