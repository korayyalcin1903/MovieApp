using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.MovieDtos
{
    public class CreateMovieDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }
        public decimal? Budget { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CategoryId { get; set; }

    }
}
