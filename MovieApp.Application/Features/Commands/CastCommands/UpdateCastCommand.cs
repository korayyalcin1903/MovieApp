using AutoMapper;
using MediatR;
using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Application.Interfaces;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Commands.CastCommands
{
    public class UpdateCastCommand: IRequest<UpdateCastDto>
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? ImgUrl { get; set; }
        public string? Biography { get; set; }
        public string? Country { get; set; }
        public bool Gender { get; set; } = true;
        public DateTime? CreatedDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand, UpdateCastDto>
        {
            private readonly IMapper _mapper;
            private readonly ICastRepository _repository;

            public UpdateCastCommandHandler(ICastRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<UpdateCastDto> Handle(UpdateCastCommand request, CancellationToken cancellationToken)
            {
                var cast = _mapper.Map<Cast>(request);
                await _repository.UpdateAsync(cast);
                return _mapper.Map<UpdateCastDto>(cast);
            }
        }
    }
}
