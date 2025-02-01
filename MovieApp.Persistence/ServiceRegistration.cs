using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Application.Interfaces;
using MovieApp.Persistence.Context;
using MovieApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=MovieApp;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICastRepository, CastRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ICastMovieRepository, CastMovieRepository>();
        }
    }
}
