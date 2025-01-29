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
    public class GetByIdCastQuery: IRequest<GetByIdCastDto>
    {
        public Guid Id { get; set; }
        public class GetByIdCastQueryHandler : IRequestHandler<GetByIdCastQuery, GetByIdCastDto>
        {
            private readonly IMapper _mapper;
            private readonly ICastRepository _repository;

            public GetByIdCastQueryHandler(IMapper mapper, ICastRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<GetByIdCastDto> Handle(GetByIdCastQuery request, CancellationToken cancellationToken)
            {
                var cast = await _repository.GetByIdAsync(request.Id);
                return _mapper.Map<GetByIdCastDto>(cast);
            }
        }
    }
}
