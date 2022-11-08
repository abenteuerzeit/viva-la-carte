﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VLC.Models.Nutrition;
using VLC.Models.Products;
using static VLC.Utils.MealManagerUtility;

namespace VLC.Models.Recipes
{
    public class Recipe
    {
        // Example = {
        //      Id:             0,
        //      Name:           "Scrambled Eggs with Toast",
        //      Instructions: 
        // }


        [Key, Required]
        public int Id { get; set; }

        [Required, DataType(DataType.Text), BindProperty]
        public string Name { get; set; } = "My Recipe";


        [Required, Display(Name = "Directions"), DataType(DataType.MultilineText), BindProperty]
        public string Instructions { get; set; } = "Write how to make this here";

        [Display(Name = "Ingredients")]
        public List<int>? ProductIdList { get; set; }

        [Display(Name = "Number of servings"), BindProperty]
        public int Portions { get; set; }

        [BindProperty]
        public double PortionSize { get; set; }

        [BindProperty]
        public int PortionUnitOfMeasurment { get; set; }

        [BindProperty]
        public double Grams { get; set; }

        public int Calories { get; set; }

        [ForeignKey(name: "Author"), BindProperty]
        public int AuthorId { get; set; }

        [DataType(DataType.Duration), BindProperty]
        public DateTime PreperationTime { get; set; }

        [DataType(DataType.Duration), BindProperty]
        public DateTime CookingTime { get; set; }

        [BindProperty]
        public Rating Rating { get; set; }

        [BindProperty]
        public bool IsFavorite { get; set; }

        [DataType(DataType.Url)]
        public string ImageURL { get; set; } = "#";

    }
}

