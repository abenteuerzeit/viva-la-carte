using VLC.Models.Nutrition;
using VLC.Models.Products;
using static VLC.Utils.MealManagerUtility;

namespace VLC.Models.Recipes
{
    public class Recipe
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Dictionary<Product, double>? Products { get; set; } = default;
        public List<string> Steps { get; set; } = new List<string>();
        public double Servings { get; set; }
        public double Grams { get; set; }
        public int Calories { get; set; }
        public NutritionFacts? NutritionData { get; set; } = default;
        public Dictionary<Product, NutritionFacts>? ProductNutritionData { get; } = default;
        public string? Author { get; set; } = default;
        public int AuthorId { get; set; }
        public DateTime PreperationTime { get; set; }
        public DateTime CookingTime { get; set; }
        public Rating Rating { get; set; }
        public bool IsFavorite { get; set; }
        public List<string> ImageURLs { get; set; } = new();





        //public void RateProduct()
        //{
        //}

        //public void Rate()
        //{
        //}

        //public void AddImage()
        //{
        //}

        //public void ToggleFavorite()
        //{
        //}

        //public void AddStep()
        //{

        //}

        //public void ChnageServingSize()
        //{

        //}
    }
}
