using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.CastDtos
{
    public class GetAllCastDto
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? ImgUrl { get; set; }
        public string? Biography { get; set; }
    }
}
