using AutoMapper;
using FluentValidation;
using MediatR;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.MovieCommands
{
    public class CreateMovieCommand : IRequest<string>
    {
        public string Title { get; set; } 
        public string ImageUrl { get; set; } 
        public string BgImage { get; set; } 
        public string Description { get; set; } 
        public string Director { get; set; } 
        public decimal Budget { get; set; }
        public string CategoryId { get; set; } 
        public string UserId { get; set; } 
        public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, string>
        {
            private readonly IMovieRepository _movieRepository;
            private readonly IMapper _mapper;

            public CreateMovieCommandHandler(IMovieRepository movieRepository, IMapper mapper)
            {
                _movieRepository = movieRepository;
                _mapper = mapper;
            }

            public async Task<string> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
            {

                try
                {
                    var movie = _mapper.Map<Movie>(request);
                    if (movie == null)
                    {
                        return "Dönüştürme hatası oluştu.";
                    }

                    await _movieRepository.CreateAsync(movie);
                    return movie.Id.ToString();
                }
                catch (AutoMapperMappingException ex)
                {
                    Console.WriteLine($"AutoMapper hatası: {ex.Message}");
                    return "Mapping hatası oluştu.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Genel hata: {ex.Message}");
                    return "Bilinmeyen bir hata oluştu.";
                }
            }

        }
    }
}
