using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Queries.MovieQueries
{
    public class GetAllMovieQuery: IRequest<List<GetAllMovieDto>>
    {
        public class GetAllMovieQueryHandler : IRequestHandler<GetAllMovieQuery, List<GetAllMovieDto>>
        {
            private readonly IMapper _mapper;
            private readonly IMovieRepository _repository;

            public GetAllMovieQueryHandler(IMapper mapper, IMovieRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<List<GetAllMovieDto>> Handle(GetAllMovieQuery request, CancellationToken cancellationToken)
            {
                var movies = await _repository.GetAllMovie();
                var result = _mapper.Map<List<GetAllMovieDto>>(movies);
                return result;

            }
        }
    }
}
