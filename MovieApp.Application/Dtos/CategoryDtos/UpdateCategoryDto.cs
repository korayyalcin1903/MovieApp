using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public string? Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryImgUrl { get; set; }
    }
}
