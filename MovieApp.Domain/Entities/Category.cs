using MovieApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string? CategoryName { get; set; }
        public string? CategoryImgUrl { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
