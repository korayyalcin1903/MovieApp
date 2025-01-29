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
    public class GetAllCommentQuery: IRequest<List<GetAllCommentDto>>
    {
        public class GetAllCommentQueryHandler : IRequestHandler<GetAllCommentQuery, List<GetAllCommentDto>>
        {
            private readonly IMapper _mapper;
            private readonly ICommentRepository _repository;

            public GetAllCommentQueryHandler(IMapper mapper, ICommentRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<List<GetAllCommentDto>> Handle(GetAllCommentQuery request, CancellationToken cancellationToken)
            {
                var Comment = await _repository.GetAllAsync();
                var result = _mapper.Map<List<GetAllCommentDto>>(Comment);
                return result;
            }
        }
    }
}
