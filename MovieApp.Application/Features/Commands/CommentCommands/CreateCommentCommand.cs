using AutoMapper;
using MediatR;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest<Guid>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Rating { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? MovieId { get; set; }

        public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Guid>
        {
            private readonly IMapper _mapper;
            private readonly ICommentRepository _repository;
            public CreateCommentCommandHandler(IMapper mapper, ICommentRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<Guid> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
            {
                var Comment = _mapper.Map<Comment>(request);
                await _repository.CreateAsync(Comment);
                return Comment.Id;
            }
        }
    }
}
