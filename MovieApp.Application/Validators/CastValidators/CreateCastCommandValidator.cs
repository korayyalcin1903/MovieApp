using FluentValidation;
using MovieApp.Application.Features.Commands.CastCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Validators.CastValidators
{
    public class CreateCastCommandValidator: AbstractValidator<CreateCastCommand>
    {
        public CreateCastCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("İsim boş geçilemez");

            RuleFor(x => x.Biography)
                .NotEmpty().WithMessage("Biyografi boş geçilemez");

            RuleFor(x => x.ImgUrl)
                .NotEmpty().WithMessage("Resim boş geçilemez");

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("Ülke boş geçilemez");

            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Cinsiyet boş geçilemez");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty().WithMessage("Doğum tarihi boş geçilemez");


        }
    }
}
