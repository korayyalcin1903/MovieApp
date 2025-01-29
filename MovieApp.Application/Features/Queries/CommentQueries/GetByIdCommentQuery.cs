using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CommentDtos;
using MovieApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Queries.CommentQueries
{
    public class GetByIdCommentQuery: IRequest<GetByIdCommentDto>
    {
        public Guid Id { get; set; }
        public class GetByIdCommentQueryHandler : IRequestHandler<GetByIdCommentQuery, GetByIdCommentDto>
        {
            private readonly IMapper _mapper;
            private readonly ICommentRepository _repository;

            public GetByIdCommentQueryHandler(IMapper mapper, ICommentRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<GetByIdCommentDto> Handle(GetByIdCommentQuery request, CancellationToken cancellationToken)
            {
                var Comment = await _repository.GetByIdAsync(request.Id);
                return _mapper.Map<GetByIdCommentDto>(Comment);
            }
        }
    }
}
