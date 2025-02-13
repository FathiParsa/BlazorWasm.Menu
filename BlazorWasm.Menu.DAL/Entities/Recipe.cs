using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Menu.DAL.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Originality { get; set; }
        public int TimeInMinutes { get; set; }
        public List<Ingridient> Ingridients { get; set; } = new List<Ingridient>();
    }
}

