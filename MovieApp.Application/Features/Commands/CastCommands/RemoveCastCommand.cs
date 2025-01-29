using AutoMapper;
using MediatR;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CastCommands
{
    public class RemoveCastCommand: IRequest<Guid>
    {
        public string Id { get; set; }

        public RemoveCastCommand(string id)
        {
            Id = id;
        }

        public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand, Guid>
        {
            private readonly ICastRepository _repository;
            private readonly IMapper _mapper;

            public RemoveCastCommandHandler(IMapper mapper, ICastRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }


            public async Task<Guid> Handle(RemoveCastCommand request, CancellationToken cancellationToken)
            {
                var cast = _mapper.Map<Cast>(request);
                await _repository.DeleteAsync(cast);
                return cast.Id;
            }
        }
    }
}
