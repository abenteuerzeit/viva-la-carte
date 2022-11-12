using VLC.Models.MealManager;
using VLC.Models.Meals;
using VLC.Models.Recipes;

namespace VLC.Services
{
    public interface IMealManagerService
    {
        //public IConfiguration APIConfigurations { get; }
        public string GetEdamamRecipesAPI_URL_For(string search_query);
        public MealPlan GetMealPlan(MealManager mealManager);
    }
}
