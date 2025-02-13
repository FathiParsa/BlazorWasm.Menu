using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BlazorWasm.Menu.Shared.Features.ManageRecipes
{
    public class IngridientDtoValidator : AbstractValidator<IngridientDto>
    {
        public IngridientDtoValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("You Should Enter a Name");
        }
    }
}
