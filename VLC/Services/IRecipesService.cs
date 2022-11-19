using VLC.Models.Recipes;

namespace VLC.Services
{
    public interface IRecipesService
    {

        public Task<Cookbook> AddToCookbook(Recipe recipe, string id);
        //bool AddToCookbook(Recipe data, out Recipe recipe);
    }
}