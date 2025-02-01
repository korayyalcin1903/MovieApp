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
    public class GetCommentByMovieIdQuery: IRequest<List<GetByIdCommentDto>>
    {
        public string? Id { get; set; }
        public class GetCommentByMovieIdQueryHandler : IRequestHandler<GetCommentByMovieIdQuery, List<GetByIdCommentDto>>
        {
            private readonly IMapper _mapper;
            private readonly ICommentRepository _repository;
            public GetCommentByMovieIdQueryHandler(IMapper mapper, ICommentRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<List<GetByIdCommentDto>> Handle(GetCommentByMovieIdQuery request, CancellationToken cancellationToken)
            {
                var comments = await _repository.GetCommentsByMovieId(request.Id);
                return _mapper.Map<List<GetByIdCommentDto>>(comments);
            }
        }
    }
}
