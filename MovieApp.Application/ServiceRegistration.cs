using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Application.Dtos.RoleDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Application.Mapping;
using MovieApp.Application.Validators.MovieValidators;
using MovieApp.Application.Validators.RoleValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var asse = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(asse);
            services.AddMediatR(asse);
            services.AddValidatorsFromAssemblyContaining<CreateMovieCommandValidator>();
        }
    }
}
