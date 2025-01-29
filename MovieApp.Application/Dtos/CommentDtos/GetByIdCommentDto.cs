using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Dtos.CommentDtos
{
    public class GetByIdCommentDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Rating { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid MovieId { get; set; }
    }
}
