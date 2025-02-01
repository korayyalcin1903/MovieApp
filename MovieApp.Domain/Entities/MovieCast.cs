using MovieApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Entities
{
    public class MovieCast: BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public Guid CastId { get; set; }
        public Cast Cast { get; set; }
    }
}
