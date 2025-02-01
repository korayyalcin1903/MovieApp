using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CastCommands
{
    public class AddCastToMovieCommand: IRequest<AddCastToMovieDto>
    {
        public string? MovieId { get; set; }
        public string? CastId { get; set; }
        public class AddCastToMovieCommandHandler : IRequestHandler<AddCastToMovieCommand, AddCastToMovieDto>
        {
            private readonly ICastMovieRepository _repository;
            private readonly IMapper _mapper;

            public AddCastToMovieCommandHandler(ICastMovieRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<AddCastToMovieDto> Handle(AddCastToMovieCommand request, CancellationToken cancellationToken)
            {
                var mapping = _mapper.Map<AddCastToMovieDto>(request);
                var result = await _repository.AddMovieCast(mapping);
                if(result == 1)
                {
                    return mapping;
                }
                return null;
            }
        }
    }
}
