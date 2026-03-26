
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Mime;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Yummer.Models;
using Yummer.DAL;

namespace Yummer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RecipeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        [HttpGet(Name = "GetAllRecipes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public  string GetAllRecipes()
        {
            var result =  RecipeDAL.GetAllRecipes(_applicationDbContext).ToList();
            return JsonConvert.SerializeObject("result");        
        }


        [HttpPost(Name = "CreateNewRecipe")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Recipe>> CreateNewRecipe(Recipe recipe)
        {
            if (recipe == null) return new BadRequestResult();
          
            await  RecipeDAL.CreateNewRecipe(_applicationDbContext, recipe);
            return new CreatedAtRouteResult(nameof(CreateNewRecipe), new { id = recipe.Id }, recipe);
        }
    }
}