using Google.Apis.PeopleService.v1.Data;
using VLC.Data;
using VLC.Models.Recipes;

namespace VLC.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly ApplicationDbContext _context;

        public RecipesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddToCookbook(Recipe data, out Recipe recipe)
        {
            try
            {
                recipe = new();
                recipe = data;
                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message, $"{data}");
            }
        }
    }
}
