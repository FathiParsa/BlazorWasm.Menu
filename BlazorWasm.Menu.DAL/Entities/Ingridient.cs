using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BlazorWasm.Menu.DAL.Entities
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RecipeId { get; set; }

        [ValidateNever]
        public Recipe Recipe { get; set; }
    }
}

