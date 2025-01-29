using AutoMapper;
using MediatR;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.MovieCommands
{
    public class RemoveMovieCommand : IRequest<Guid>
    {
        public string Id { get; set; }

        public RemoveMovieCommand(string id)
        {
            Id = id;
        }

        public class RemoveMovieCommandHandler : IRequestHandler<RemoveMovieCommand, Guid>
        {
            private readonly IMovieRepository _repository;
            private readonly IMapper _mapper;

            public RemoveMovieCommandHandler(IMovieRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<Guid> Handle(RemoveMovieCommand request, CancellationToken cancellationToken)
            {
                var movie = _mapper.Map<Movie>(request);
                await _repository.DeleteAsync(movie);
                return movie.Id;
            }
        }
    }
}
