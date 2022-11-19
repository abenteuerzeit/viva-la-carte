using Google.Apis.PeopleService.v1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using VLC.Areas.Identity.Pages.Account;
using VLC.Data;
using VLC.Models.Recipes;

namespace VLC.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<LoginModel> _logger;



        public RecipesService(ApplicationDbContext context, ILogger<LoginModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Cookbook> AddToCookbook(Recipe recipe, string userId)
        {
            try
            {
                List<Cookbook> books = await _context.Cookbooks.ToListAsync();
                Cookbook cookbook = books.FirstOrDefault(b => b.UserId == userId, new());
                cookbook.UserId = userId;
                cookbook.Recipes.Add(recipe);
                books.Add(cookbook);
                await _context.SaveChangesAsync();
                //_logger.LogInformation($"The recipe for '{recipe.Label}' was succesfully added to the user's (id {cookbook.UserId}) cookbook (id: {cookbook.Id})!");
                return cookbook;

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message, $"{recipe}");
            }
        }

        ///// <summary>
        ///// Retrieves the specified user's default cookbook. 
        ///// If no coookbook is found, a new one is created by default.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns>The default cookbook</returns>
        //private async Task<Cookbook> GetCookbookByUserId(string id)
        //{

        //}
    }
}
