using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yummer.Models;
namespace Yummer.DAL
{
    public static class RecipeDAL
    {
        public static async Task CreateNewRecipe(ApplicationDbContext db, Recipe user)
        {
            await db.Recipe.AddAsync(user);
            await db.SaveChangesAsync();
        }
        public static IQueryable<Recipe> GetRecipeById(ApplicationDbContext db, int recipeId)
            => db.Recipe.Select(x => x)
                 .Where(x => x.Id == recipeId);


        public static IQueryable<Recipe> GetAllRecipes(ApplicationDbContext db)
            => db.Recipe.Select(x => x);


    }
    



}
