using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;
using VLC.Models.Recipes;
using static VLC.Utils.MealManagerUtility;

namespace VLC.Models.Meals
{
    public class Meal
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; } = "Breakfast";
        public string Description { get; set; } = "Full English Breakfast";

        [ForeignKey(name: "Recipe"), Required]
        public int MainDishId { get; set; }

        [Display(Name = "Number of side dishes")]
        public int NumberOfSides { get; set; } = 2;

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Rating { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsGlutenFree { get; set; }

    }
}
