using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.CastDtos
{
    public class CreateCastDto
    {
        public string? FullName { get; set; }
        public string? ImgUrl { get; set; }
        public string? Biography { get; set; }
        public string? Country { get; set; }
        public bool Gender { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
