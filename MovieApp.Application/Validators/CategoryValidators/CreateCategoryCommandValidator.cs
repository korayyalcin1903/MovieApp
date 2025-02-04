using FluentValidation;
using MovieApp.Application.Features.Commands.CategoryCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Validators.CategoryValidators
{
    public class CreateategoryCommandValidator: AbstractValidator<CreateCategoryCommand>
    {
        public CreateategoryCommandValidator() {

            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("Kategori ismi boş geçilemez");

            RuleFor(x => x.CategoryImgUrl)
                .NotEmpty().WithMessage("Kategori resmi boş geçilemez");
        }
    }
}
