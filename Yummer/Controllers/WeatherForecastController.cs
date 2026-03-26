
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Mime;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Yummer.Models;

namespace Strength_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        [HttpGet(Name = "GetAllRecipes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string GetAllUsers()
        {
            /* var result = Make call to Data Service
                            Example:
                                     MyDataSerive.GetAllUsers(_applicationDbContext).ToList();
            */

            //return JsonConvert.SerializeObject(result);
            return JsonConvert.SerializeObject(""); // place holder until I stub

        }


        [HttpPost(Name = "CreateNewRecipe")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Recipe>> CreateNewRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                return new BadRequestResult();
            }

           // await  MyCreationalSerive.CreateNewRecipe(_applicationDbContext, recipe);

            return new CreatedAtRouteResult(nameof(CreateNewRecipe), new { id = recipe.Id }, recipe);
        }



    }
}