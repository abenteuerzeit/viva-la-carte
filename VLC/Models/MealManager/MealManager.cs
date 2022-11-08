using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VLC.Models.Recipes;
using static VLC.Models.MealManager.Diet;

namespace VLC.Models.MealManager
{
    public class MealManager
    {
        [Required, Key]
        public int Id { get; set; }
        #region Input
        [Required, Display(Name = "Total Calories"), BindProperty]
        public int TotalCalories { get; set; } = 2000 * 7; // 2000kcal for 7 days

        [Required, Display(Name = "Number of meals")]
        public int MealCount { get; set; } = 3 * 7; //3 meals for each day of the week

        [Required, Display(Name = "Diet Preference")]
        public Diets Diet { get; set; } = Diets.Whatever;

        [ForeignKey("MealPlan")]
        public int MealPlanId { get; set; }


        #endregion

        //public MealManager()
        //{
        //    TotalCalories = default;
        //    MealCount = default;
        //    Diet = default;
        //    AdvandedOptions = default;
        //    ThisWeeksMealPlan = default;
        //}
    }
}
