using VLC.Models.Recipes;
using static VLC.Models.MealManager.Diet;

namespace VLC.Models.MealManager
{
    public class MealManager
    {
        #region Input

        private int totalCalories { get; set; } = 2000 * 7; // 2000kcal for 7 days

        private int mealCount { get; set; } = 3 * 7; //3 meals for each day of the week

        protected Diets diet { get; set; } = Diets.Whatever;

        private List<Recipe> Meals => new List<Recipe>();

        private bool advandedOptions { get; set; } = false;

        private string? ThisWeeksMealPlan { get; set; }


        #endregion

        public MealManager()
        {
            totalCalories = default;
            mealCount = default;
            diet = default;
            advandedOptions = default;
            ThisWeeksMealPlan = default;
        }
    }
}
