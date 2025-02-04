using FluentValidation;
using MovieApp.Application.Features.Commands.CommentCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Validators.CommentValidators
{
    public class CreateCommentValidator: AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim boş geçilemez");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email boş geçilemez");

            RuleFor(x => x.Rating)
                .NotEmpty().WithMessage("Puan boş geçilemez");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş geçilemez");

            RuleFor(x => x.MovieId)
                .NotEmpty().WithMessage("MovieId boş geçilemez");

            
        }
    }
}
