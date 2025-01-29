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
    public class GetByIdCategoryQuery: IRequest<GetByIdMovieDto>
    {
        public string Id { get; set; }
        public class GetByIdMovieQueryHandler: IRequestHandler<GetByIdCategoryQuery, GetByIdMovieDto>
        {
            private readonly IMapper _mapper;
            private readonly IMovieRepository _repository;

            public GetByIdMovieQueryHandler(IMovieRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<GetByIdMovieDto> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
            {
                var movie = await _repository.GetMovieById(request.Id);
                return _mapper.Map<GetByIdMovieDto>(movie);
            }
        }
    }
}
