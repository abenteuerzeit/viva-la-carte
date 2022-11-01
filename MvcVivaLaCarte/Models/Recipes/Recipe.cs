using System;
using System.Security.Policy;
using MvcVivaLaCarte.Models.Products;
using MvcVivaLaCarte.Models.Users;

namespace MvcVivaLaCarte.Models.Recipes
{
    public class Recipe
    {
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
            this.Id = id;
            this.Title = name;
            this.Author = author;
            this.Ingredients = ingredients;
            this.Directions = directions;
        }
    }
}

