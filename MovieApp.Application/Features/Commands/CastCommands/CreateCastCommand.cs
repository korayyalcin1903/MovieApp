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
    public class CreateCastCommand : IRequest<Guid>
    {
        public string? FullName { get; set; }
        public string? ImgUrl { get; set; }
        public string? Biography { get; set; }
        public string? Country { get; set; }
        public bool Gender { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand, Guid>
        {
            private readonly IMapper _mapper;
            private readonly ICastRepository _repository;
            public CreateCastCommandHandler(IMapper mapper, ICastRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<Guid> Handle(CreateCastCommand request, CancellationToken cancellationToken)
            {
                var cast = _mapper.Map<Cast>(request);
                await _repository.CreateAsync(cast);
                return cast.Id;
            }
        }
    }
}
