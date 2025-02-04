using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.MovieDtos
{
    public class GetMovieByCategoryDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CategoryId { get; set; }
        public string UserId { get; set; }
    }
}
