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
    public class GetAllCastQuery: IRequest<List<GetAllCastDto>>
    {
        public class GetAllCastQueryHandler : IRequestHandler<GetAllCastQuery, List<GetAllCastDto>>
        {
            private readonly IMapper _mapper;
            private readonly ICastRepository _repository;

            public GetAllCastQueryHandler(IMapper mapper, ICastRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<List<GetAllCastDto>> Handle(GetAllCastQuery request, CancellationToken cancellationToken)
            {
                var cast = await _repository.GetAllAsync();
                var result = _mapper.Map<List<GetAllCastDto>>(cast);
                return result;
            }
        }
    }
}
