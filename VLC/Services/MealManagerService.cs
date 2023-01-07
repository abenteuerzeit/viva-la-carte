using Microsoft.CodeAnalysis.Recommendations;
using System;
using System.Configuration;
using System.Numerics;
using System.Web.Mvc;
using VLC.Data;
using VLC.Models.MealManager;
using VLC.Models.Meals;
using VLC.Models.Products;
using VLC.Models.Recipes;
using static VLC.Utils.MealManagerUtility;

namespace VLC.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MealManagerService : IMealManagerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;

        public MealManagerService(ApplicationDbContext context, IConfiguration config) // , RequestDelegate next)
        {
            _context = context;
            _config = config;
        }

        /// <summary>
        /// 1. Select recipes
        /// 2. Shop for ingredients
        /// 3. Prepare those ingredients
        /// https://iamherbalifenutrition.com/healthy-weight/build-meal-plan/
        /// https://www.thekitchn.com/the-beginners-guide-to-meal-planning-what-to-know-how-to-succeed-and-what-to-skip-242413
        /// </summary>
        public MealPlan GetMealPlan(MealManager manager)
        {
            //ProteinPlan proteinPlan = GetProteinPlan(manager);
            //WeightGoal option = manager.Goal;

            MealPlan mealPlan = new() { NumberOfMeals = manager.MealCount, Calories = 0, Recipes = new List<Recipe>() };
            //Recipe recipe = new Recipe()
            //{
            //    Name = "Adrian's Scrambled Eggs",
            //    AuthorId = 0,
            //    ProductIdList = new List<Product>() { new Product(), new Product() },
            //    Instructions = "Just break some eggs in a frying pan and fry them for a few minutes while stirring the eggs. Plate them and your done! ",
            //    Calories = 250,
            //    PreperationTime = new TimeSpan(hours: 0, minutes: 3, seconds: 30),
            //    CookingTime = new TimeSpan(hours: 0, minutes: 5, seconds: 0),
            //    Grams = 200
            //};

            while (mealPlan.Calories < manager.TotalCalories)
            {
                //mealPlan.Calories += recipe.Calories;
                //mealPlan.Recipes.Add(recipe);
                //Console.WriteLine($"{recipe.Name} with Id {recipe.Id} added to meal plan with Id {mealPlan.Id}");
                //Console.WriteLine($"The number of meals in this plan is: {mealPlan.Recipes.Count}");
            }
            return mealPlan;

        }

        ///// <summary>
        ///// Helps you determine the suggested meal plan for you, and your plan is designed to match your individual needs for protein and calories.
        ///// The Protein Plan Selection Tool will recommended Meal Plan A, B, C or D, based on your gender, weight and height.
        ///// </summary>
        ///// <returns></returns>
        ///// <exception cref="NotImplementedException"></exception>
        //private ProteinPlan GetProteinPlan(MealManagers manager)
        //{
        //    switch (manager.Gender)
        //    {
        //        case Gender.Male:
        //            // TODO: select Plan A, B, C, or D based on height and weight
        //            // https://iamherbalifenutrition.com/wp-content/uploads/2021/12/How-much-protein-do-you-need-meal-chart.pdf
        //            return ProteinPlan.D;
        //        case Gender.Female:
        //            // TODO: select Plan A, B, C, or D based on height or weight
        //            return ProteinPlan.C;
        //        default:
        //            return ProteinPlan.B;
        //    }

        //}
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddleExtensions
    {
        public static IApplicationBuilder UseMiddle(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MealManagerService>();
        }
    }
}
