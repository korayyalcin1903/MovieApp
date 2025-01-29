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
    public class RemoveCommentCommand: IRequest<Guid>
    {
        public string Id { get; set; }

        public RemoveCommentCommand(string id)
        {
            Id = id;
        }

        public class RemoveCommentCommandHandler : IRequestHandler<RemoveCommentCommand, Guid>
        {
            private readonly ICommentRepository _repository;
            private readonly IMapper _mapper;

            public RemoveCommentCommandHandler(IMapper mapper, ICommentRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }


            public async Task<Guid> Handle(RemoveCommentCommand request, CancellationToken cancellationToken)
            {
                var Comment = _mapper.Map<Comment>(request);
                await _repository.DeleteAsync(Comment);
                return Comment.Id;
            }
        }
    }
}
