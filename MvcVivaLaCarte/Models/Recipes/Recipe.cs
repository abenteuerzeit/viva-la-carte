using MvcVivaLaCarte.Models.Products;
using MvcVivaLaCarte.Models.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;


namespace MvcVivaLaCarte.Models.Recipes
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public User? Author { get; set; }
        public List<Product>? Ingredients { get; set; }
        public List<string>? Directions { get; set; }
        // TODO
        //public string Image { get; set; }

        public Recipe()
        {

        }

        public Recipe(int id, string name, User author, List<Product> ingredients, List<string> directions)
        {
            Id = id;
            Title = name;
            Author = author;
            Ingredients = ingredients;
            Directions = directions;
        }
    }
}

