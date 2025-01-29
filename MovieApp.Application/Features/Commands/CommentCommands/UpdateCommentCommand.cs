using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CommentDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CommentCommands
{
    public class UpdateCommentCommand: IRequest<UpdateCommentDto>
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Rating { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? MovieId { get; set; }
        public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, UpdateCommentDto>
        {
            private readonly IMapper _mapper;
            private readonly ICommentRepository _repository;

            public UpdateCommentCommandHandler(ICommentRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<UpdateCommentDto> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
            {
                var Comment = _mapper.Map<Comment>(request);
                await _repository.UpdateAsync(Comment);
                return _mapper.Map<UpdateCommentDto>(Comment);
            }
        }
    }
}
