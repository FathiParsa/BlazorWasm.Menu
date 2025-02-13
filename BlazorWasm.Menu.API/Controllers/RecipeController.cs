using BlazorWasm.Menu.DAL;
using BlazorWasm.Menu.DAL.Entities;
using BlazorWasm.Menu.Shared.Features.ManageRecipes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.Menu.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly MenuDbContext _menuDbContext;
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(MenuDbContext menuDbContext , ILogger<RecipeController> logger)
        {
            _menuDbContext = menuDbContext;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Add(RecipeDto model)
        {
            try
            {
                Recipe recipe = new Recipe
                {
                    Name = model.Name,
                    Description = model.Description,
                    Originality = model.Originality,
                    Price = model.Price,
                    TimeInMinutes = model.TimeInMinutes,
                    ImageUrl = "Not Set",
                    Ingridients = model.Ingridients.Select(c => new Ingridient
                    {
                        Name = c.Name,
                    }).ToList(),
                };

                await _menuDbContext.Recipes.AddAsync(recipe);
                await _menuDbContext.SaveChangesAsync();
                return Ok(recipe.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"<< Baddness >>");
                return BadRequest(-1);
            }
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetAll()
        {
            var recipes = await _menuDbContext.Recipes.Include(C => C.Ingridients).ToListAsync();
            return Ok(recipes);
        }
    }
}
