using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using MovieApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Persistence.Repository
{
    public class CastMovieRepository : GenericRepository<MovieCast>, ICastMovieRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper _mapper;

        public CastMovieRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public async Task<int> AddMovieCast(AddCastToMovieDto dto)
        {
            var movieCast = context.MovieCasts.Where(x => x.CastId == Guid.Parse(dto.CastId) && x.MovieId == Guid.Parse(dto.MovieId)).FirstOrDefault();
            var mapping = _mapper.Map<MovieCast>(dto);
            if (movieCast == null)
            {
                await context.MovieCasts.AddAsync(mapping);
                var result = await context.SaveChangesAsync();
                return result;
            }
            return 0;
        }

        public async Task<List<GetAllCastDto>> GetAllCastByMovieId(string id)
        {
            var casts = await context.MovieCasts.Include(x => x.Cast).Where(x => x.MovieId == Guid.Parse(id)).ToListAsync();
            var result = _mapper.Map<List<GetAllCastDto>>(casts);
            return result;
        }
    }
}
