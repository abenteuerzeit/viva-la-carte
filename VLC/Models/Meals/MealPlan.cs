using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VLC.Models.Meals
{
    public class MealPlan
    {
        [Key]
        public int Id { get; set; }

        [BindProperty, Required]
        public int Calories { get; set; }

        [BindProperty, Required]
        [Range(1, 10, ErrorMessage = "The number of meals must be between 1 and 10")]
        public int NumberOfMeals { get; set; }

        [Display(Name = "Meals")]
        public List<int> MealIds { get; set; } = new List<int>();

    }
}
