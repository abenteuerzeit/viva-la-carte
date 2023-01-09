using VLC.Models.MealManager;
using VLC.Models.Meals;
using VLC.Models.Recipes;

namespace VLC.Services
{
    public interface IMealManagerService
    {
        //public IConfiguration APIConfigurations { get; }
        public MealPlan GetMealPlan(MealManager mealManager);
    }
}
