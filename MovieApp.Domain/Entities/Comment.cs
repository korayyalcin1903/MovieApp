using MovieApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Entities
{
    public class Comment:BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Rating { get; set; }
        public string? Description { get; set; }
        public Movie? Movie { get; set; }
        public Guid MovieId { get; set; }
    }
}
