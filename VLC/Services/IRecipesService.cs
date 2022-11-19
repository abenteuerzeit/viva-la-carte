using VLC.Models.Recipes;

namespace VLC.Services
{
    public interface IRecipesService
    {
        bool AddToCookbook(Recipe data, out Recipe recipe);
    }
}