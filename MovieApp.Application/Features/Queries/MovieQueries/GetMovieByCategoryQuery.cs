using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Queries.MovieQueries
{
    public class GetMovieByCategoryQuery: IRequest<List<GetMovieByCategoryDto>>
    {
        public string CategoryId { get; set; }

        public GetMovieByCategoryQuery(string categoryId)
        {
            CategoryId = categoryId;
        }

        public class GetMovieByCategoryQueryHandler : IRequestHandler<GetMovieByCategoryQuery, List<GetMovieByCategoryDto>>
        {
            private readonly IMovieRepository _repository;
            private readonly IMapper _mapper;

            public GetMovieByCategoryQueryHandler(IMovieRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<List<GetMovieByCategoryDto>> Handle(GetMovieByCategoryQuery request, CancellationToken cancellationToken)
            {
                var movies = await _repository.GetMovieByCategoryId(request.CategoryId);
                return _mapper.Map<List<GetMovieByCategoryDto>>(movies);  
            }
        }
    }
}
