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
    public class CastRepository : GenericRepository<Cast>, ICastRepository
    {
        public CastRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
