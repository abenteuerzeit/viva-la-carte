using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VLC.Models.Recipes;
using static VLC.Utils.MealManagerUtility;

namespace VLC.Models.MealManager
{
    /// <summary>
    /// This model represents the form used to generate a meal plan. 
    /// </summary>
    public class MealManager
    {
        [Required, Key]
        public int Id { get; set; }

        //[ForeignKey("MealPlan")]
        //public int MealPlanId { get; set; }

        #region User Input
        [Required, Display(Name = "Total Calories"), BindProperty]
        public int TotalCalories { get; set; } = 2000;

        [Required, Display(Name = "Number of meals"), BindProperty]
        public int MealCount { get; set; } = 3;

        [Required, Display(Name = "Diet Preference"), BindProperty]
        public Diets Diet { get; set; } = Diets.Whatever;

        [Required, BindProperty]
        public WeightGoal Goal { get; set; }

        [Required, BindProperty]
        public MeasurementSystem MeasurementSystem { get; set; }

        [BindProperty]
        public double Height { get; set; }

        [BindProperty]
        public double Weight { get; set; }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public BodyFat BodyFat { get; set; }
        //public ACE_BodyFat BodyFat { get; set; }

        [BindProperty]
        public ActivityLevel ActivityLevel { get; set; }
        #endregion
    }
}
