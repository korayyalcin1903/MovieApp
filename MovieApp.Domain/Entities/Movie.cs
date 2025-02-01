using MovieApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Entities
{
    public class Movie: BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? BgImage { get; set; }
        public string? Director { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Budget { get; set; }
        public List<MovieCast> MovieCasts { get; set; } = new();
        public Category? Category { get; set; }
        public Guid CategoryId { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
