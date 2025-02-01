using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Queries.CastQueries
{
    public class CastWithMovieQuery: IRequest<List<GetAllCastDto>>
    {
        public string? Id { get; set; }
        public class CastWithMovieQueryHandler : IRequestHandler<CastWithMovieQuery, List<GetAllCastDto>>
        {
            private readonly ICastMovieRepository _repository;
            private readonly IMapper _mapper;

            public CastWithMovieQueryHandler(ICastMovieRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }


            public async Task<List<GetAllCastDto>> Handle(CastWithMovieQuery request, CancellationToken cancellationToken)
            {
                var casts = await _repository.GetAllCastByMovieId(request.Id);
                var result = _mapper.Map<List<GetAllCastDto>>(casts);
                return result;
            }
        }
    }
}
