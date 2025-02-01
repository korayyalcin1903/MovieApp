using MovieApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Entities
{
    public class Cast: BaseEntity
    {
        public string? FullName { get; set; }
        public string? Biography { get; set; }
        public string? ImgUrl { get; set; }
        public string? Country { get; set; }
        public bool Gender { get; set; } = true;
        public DateTime? DateOfBirth { get; set; }
        public List<MovieCast> MovieCasts { get; set; } = new();
    }
}
