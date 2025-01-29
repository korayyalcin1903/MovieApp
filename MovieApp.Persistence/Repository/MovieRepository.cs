using Microsoft.EntityFrameworkCore;
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
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext context;
        public MovieRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllMovie()
        {
            var movie = await context.Movies.Include(x => x.Category).ToListAsync();
            return movie;
        }

        public async Task<List<Movie>> GetMovieByCategoryId(string id)
        {
            var movies = await context.Movies.Where(x => x.CategoryId == Guid.Parse(id)).ToListAsync();
            return movies;
        }

        public async Task<Movie> GetMovieById(string id)
        {
            var movie = await context.Movies.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            return movie;
        }
    }
}
