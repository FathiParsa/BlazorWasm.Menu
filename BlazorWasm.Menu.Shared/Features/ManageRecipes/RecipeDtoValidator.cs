using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BlazorWasm.Menu.Shared.Features.ManageRecipes
{
    public class RecipeDtoValidator : AbstractValidator<RecipeDto>
    {
        public RecipeDtoValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("This Field Can't Be Empty.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("This Field Can't Be Empty.");
            RuleFor(c => c.Originality).NotEmpty().WithMessage("This Field Can't Be Empty.");
            RuleFor(c => c.Price).GreaterThan(0).WithMessage("Enter a Price Greater Than 0.");
            RuleFor(c => c.TimeInMinutes).GreaterThan(0).WithMessage("Enter a Time Greater Than 0.");
            RuleFor(c => c.Ingridients).NotEmpty().WithMessage("Recipe Must Have an Ingridient.");
            RuleForEach(c => c.Ingridients).SetValidator(new IngridientDtoValidator());
        }
    }
}
