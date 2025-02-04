using FluentValidation;
using MovieApp.Application.Features.Commands.MovieCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Validators.MovieValidators
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık boş geçilemez")
                .MaximumLength(100).WithMessage("100 karakterden fazla girilemez");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama Boş geçilemez");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Resim Boş geçilemez");
            RuleFor(x => x.Director)
                .NotEmpty().WithMessage("Director Boş geçilemez");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId boş geçilemez");

            RuleFor(x => x.BgImage)
                .NotEmpty().WithMessage("Background Image boş geçilemez");

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("CategoryId boş geçilemez");

            RuleFor(x => x.Budget)
                .NotEmpty().WithMessage("Bütçe boş geçilemez");
        }
    }
}
