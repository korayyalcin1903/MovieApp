using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.MovieDtos
{
    public class GetAllMovieDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public string CategoryName { get; set; }
    }
}
