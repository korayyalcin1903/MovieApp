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
    public class UpdateRoleValidation: AbstractValidator<UpdateRoleDto>
    {
        public UpdateRoleValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Rol adı boş geçilemez");
        }
    }
}
