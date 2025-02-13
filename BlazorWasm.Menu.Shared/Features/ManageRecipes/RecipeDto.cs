using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Menu.Shared.Features.ManageRecipes
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Originality { get; set; }
        public int TimeInMinutes { get; set; }
        public List<IngridientDto> Ingridients { get; set; } = new List<IngridientDto>();
    }
}
