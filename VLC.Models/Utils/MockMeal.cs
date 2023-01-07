using VLC.Models.Recipes;

namespace VLC.Utils
{
    public static class MockMeal
    {
        public static int Id { get; set; }
        public static string Name => "Scrambled Eggs with Avocado Toast and Orange Juice";
        public static List<Recipe> Recipes => new();

        //public static List<Recipe> AddRecipesToViewBag()
        //{
        //    // TODO Service Recipes
        //    var Recipes = new List<Recipe>();
        //    Recipes.Add(new Recipe()
        //    {
        //        //Id = Id++,
        //        Name = "Scrambled Eggs",
        //        // https://api.edamam.com/api/recipes/v2/?app_id=54fe811b&app_key=3dc43f24bc09518326e7783ceb08d984&type=public&q=eggs
        //    });
        //    return Recipes;
        //}
    }

    //public static class Recipe
    //{

    //}
}