using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using VLC.Models.Entity;
using VLC.Models.Nutrition;
using VLC.Models.Products;
using VLC.Models.Recipes;
//using static VLC.Models.API.RecipeSearch;
using static VLC.Utils.MealManagerUtility;

// TODO: Map unmapped values.

namespace VLC.Models.Recipes
{
    public partial class Recipe
    {
        [Key, Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        //[Required, DataType(DataType.Text), BindProperty]
        //public string Name { get; set; } = "My Recipe";

        //[Required, Display(Name = "Directions"), DataType(DataType.MultilineText), BindProperty]
        //public string Instructions { get; set; } = "Write how to make this here";

        //[Display(Name = "Ingredients")]
        //public List<Product>? ProductIdList { get; set; }

        //[Display(Name = "Number of servings"), BindProperty]
        //public int Portions { get; set; }

        //[BindProperty]
        //public double PortionSize { get; set; }

        //[BindProperty]
        //public int PortionUnitOfMeasurment { get; set; }

        //[BindProperty]
        //public double Grams { get; set; }


        //[ForeignKey(name: "Author"), BindProperty]
        //public int AuthorId { get; set; }

        //[DataType(DataType.Duration), BindProperty]
        //public TimeSpan PreperationTime { get; set; }

        //[DataType(DataType.Duration), BindProperty]
        //public TimeSpan CookingTime { get; set; }

        //[BindProperty]
        //public Rating Rating { get; set; }

        //[BindProperty]
        //public bool IsFavorite { get; set; }

        //[DataType(DataType.Url)]
        //public string ImageURL { get; set; } = "#";

        //public virtual ICollection<Cookbook> Cookbooks { get; set; }

        [BindProperty]
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [BindProperty]
        [JsonProperty("label")]
        public string Label { get; set; }

        [BindProperty]
        [JsonProperty("image")]
        public Uri Image { get; set; }

        [BindProperty]
        [JsonProperty("images")]
        public Images Images { get; set; }

        [BindProperty]
        [JsonProperty("source")]
        public string Source { get; set; }

        [BindProperty]
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [BindProperty]
        [JsonProperty("shareAs")]
        public Uri ShareAs { get; set; }

        [BindProperty]
        [JsonProperty("yield")]
        public long Yield { get; set; }

        [JsonProperty("dietLabels")]
        [NotMapped]
        public List<DietLabel> DietLabels { get; set; }

        [JsonProperty("health")]
        [NotMapped]
        public List<HealthLabel> HealthLabels { get; set; }

        [JsonProperty("cautions")]
        [NotMapped]
        public List<string> Cautions { get; set; }

        [JsonProperty("ingredientLines")]
        [NotMapped]
        public List<string> IngredientLines { get; set; }

        [BindProperty]
        [JsonProperty("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [BindProperty]
        [JsonProperty("calories")]
        public double Calories { get; set; }

        [BindProperty]
        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        [BindProperty]
        [JsonProperty("totalTime")]
        public long TotalTime { get; set; }

        [JsonProperty("cuisineType")]
        [NotMapped]
        public List<string> CuisineType { get; set; }

        [JsonProperty("mealType")]
        [NotMapped]
        public List<MealType> MealType { get; set; }

        [JsonProperty("dishType")]
        [NotMapped]
        public List<DishType> DishType { get; set; }

        [JsonProperty("totalNutrients")]
        [NotMapped]
        public Dictionary<string, Total> TotalNutrients { get; set; }

        [JsonProperty("totalDaily")]
        [NotMapped]
        public Dictionary<string, Total> TotalDaily { get; set; }

        [JsonProperty("digest")]
        [NotMapped]
        public List<Digest> Digest { get; set; }

        public int CountCaloriesPerServing()
        {
            var caloriesPerServing = Convert.ToInt32(Calories / Yield);
            return caloriesPerServing;
        }

        public int ConvertCaloriesToInt()
        {
            return Convert.ToInt32(Calories);
        }

        //TODO Refactor 2 methods in 1, take dictionary as parameter and pass it to the method
        //public string CountTotalNutrientsPerServing(string computedValue)
        //{
        //    return (TotalNutrients.GetValueOrDefault(computedValue).Quantity / Yield).ToString("#");
        //}

        //public int CountTotalDailyPerServing(string computedValue)
        //{

        //    return Convert.ToInt32(TotalDaily.GetValueOrDefault(computedValue).Quantity / Yield);
        //}

        public string CountPerServing(string recipeDetails, string computedValue)
        {
            switch (recipeDetails)
            {
                case "totalNutrients":
                    return (TotalNutrients.GetValueOrDefault(computedValue).Quantity / Yield).ToString("#");
                case "totalDaily":
                    return (TotalDaily.GetValueOrDefault(computedValue).Quantity / Yield).ToString("#");
                case "digest":
                    return CountDigestPerServing(computedValue);
            }
            throw new Exception($"There is no value provided!");
        }

        public string CountDigestPerServing(string value)
        {
            for (int i = 0; i < Digest.Count; i++)
            {
                switch (value)
                {
                    case "total":
                        return (Digest[i].Total / Yield).ToString("#") + Digest[i].Unit.ToString().ToLower();
                    case "daily":
                        return (Digest[i].Daily / Yield).ToString("#") + Digest[i].Unit.ToString().ToLower();
                }
            }

            throw new Exception($"There is no value provided!");
        }

    }
}


