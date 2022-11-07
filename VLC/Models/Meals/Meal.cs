using System.Net.Http.Headers;
using VLC.Models.Recipes;
using static VLC.Utils.MealManagerUtility;

namespace VLC.Models.Meals
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Breakfast";
        public string Description { get; set; } = "Full English Breakfast";
        public int NumberOfDishesPerMeal { get; set; } = 3;
        public List<Recipe> Courses { get; set; } = new List<Recipe>();

        public Meal()
        {
            Courses = new();


        }




        public void CreateMeal()
        {
            Meal meal = new Meal();
        }

        public List<Meal> GetMeals()
        {
            throw new NotImplementedException();
        }

    }
}
