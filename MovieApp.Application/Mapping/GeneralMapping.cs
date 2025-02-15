﻿using AutoMapper;
using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Application.Dtos.CategoryDtos;
using MovieApp.Application.Dtos.CommentDtos;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Application.Dtos.RoleDtos;
using MovieApp.Application.Dtos.UserDtos;
using MovieApp.Application.Features.Commands.CastCommands;
using MovieApp.Application.Features.Commands.CategoryCommands;
using MovieApp.Application.Features.Commands.CommentCommands;
using MovieApp.Application.Features.Commands.MovieCommands;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            // Movie
            CreateMap<Movie, GetAllMovieDto>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.CategoryName))
                .ReverseMap();
            CreateMap<Movie, UpdateMovieDto>().ReverseMap();
            CreateMap<Movie, GetByIdMovieDto>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.CategoryName))
                .ReverseMap();
            CreateMap<Movie, GetMovieByCategoryDto>().ReverseMap();

            // Movie Command
            CreateMap<CreateMovieCommand, Movie>().ReverseMap();
            CreateMap<UpdateMovieCommand, Movie>().ReverseMap();
            CreateMap<RemoveMovieCommand, Movie>().ReverseMap();


            // Category
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetAllCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            // Category Command
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<UpdateCategoryCommand, Category>().ReverseMap();
            CreateMap<RemoveCategoryCommand, Category>().ReverseMap();

            // Cast
            CreateMap<Cast, CreateCastDto>().ReverseMap();
            CreateMap<Cast, GetAllCastDto>().ReverseMap();
            CreateMap<Cast, GetByIdCastDto>().ReverseMap();
            CreateMap<Cast, UpdateCastDto>().ReverseMap();
            CreateMap<MovieCast, AddCastToMovieDto>().ReverseMap();

            // MovieCast
            CreateMap<MovieCast, Cast>().ReverseMap();
            CreateMap<MovieCast, GetAllCastDto>().ReverseMap();
            CreateMap<AddCastToMovieDto, MovieCast>().ReverseMap();
            CreateMap<AddCastToMovieCommand, AddCastToMovieDto>();
            CreateMap<MovieCast, GetAllCastDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Cast.FullName))
                .ForMember(dest => dest.ImgUrl, opt => opt.MapFrom(src => src.Cast.ImgUrl))
                .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.Cast.Biography));


            // Cast Command

            CreateMap<CreateCastCommand, Cast>().ReverseMap();
            CreateMap<RemoveCastCommand, Cast>().ReverseMap();
            CreateMap<UpdateCastCommand, Cast>().ReverseMap();
            CreateMap<AddCastToMovieCommand, Cast>().ReverseMap();
            CreateMap<AddCastToMovieCommand, AddCastToMovieDto>();

            // Comment 
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, GetAllCommentDto>().ReverseMap();
            CreateMap<Comment, GetByIdCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();

            // Comment Command
            CreateMap<CreateCommentCommand, Comment>().ReverseMap();
            CreateMap<RemoveCommentCommand, Comment>().ReverseMap();
            CreateMap<UpdateCommentCommand, Comment>().ReverseMap();

            // Auth
            CreateMap<RegisterDto, User>().ReverseMap();
            CreateMap<LoginDto, User>().ReverseMap();
            CreateMap<GetUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();

            // Role
            CreateMap<CreateRoleDto, Role>().ReverseMap();
            CreateMap<UpdateRoleDto, Role>().ReverseMap();

        }
    }
}
