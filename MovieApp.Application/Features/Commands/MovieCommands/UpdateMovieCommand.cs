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

namespace MovieApp.Application.Features.Commands.MovieCommands
{
    public class UpdateMovieCommand : IRequest<UpdateMovieDto>
    {
        public string Id { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public string? BgImage { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }
        public decimal? Budget { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CategoryId { get; set; }
        public class UpdateMovieCommandHandler : IRequestHandler<UpdateMovieCommand, UpdateMovieDto>
        {
            private readonly IMapper _mapper;
            private readonly IMovieRepository _repository;

            public UpdateMovieCommandHandler(IMapper mapper, IMovieRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<UpdateMovieDto> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
            {
                var movie = _mapper.Map<Movie>(request);
                await _repository.UpdateAsync(movie);
                return _mapper.Map<UpdateMovieDto>(movie);
            }
        }
    }
}
