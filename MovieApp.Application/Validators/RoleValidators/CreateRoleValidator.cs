using FluentValidation;
using MovieApp.Application.Dtos.RoleDtos;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Validators.RoleValidators
{
    public class CreateRoleValidator: AbstractValidator<CreateRoleDto>
    {
        public CreateRoleValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Rol adı boş geçilemez");
        }
    }
}
