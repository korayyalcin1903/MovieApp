﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.MovieDtos
{
    public class UpdateMovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } 
        public string BgImage { get; set; } 
        public string Description { get; set; } 
        public string Director { get; set; } 
        public decimal Budget { get; set; } 
        public string ImageUrl { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid CategoryId { get; set; }
        public Guid UserId { get; set; }
    }
}
