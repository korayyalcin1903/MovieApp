using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.CastDtos
{
    public class AddCastToMovieDto
    {
        public string? MovieId { get; set; }

        public string? CastId { get; set; }
    }
}
