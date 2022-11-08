using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VLC.Models.Meals;
using VLC.Models.MealManager;

namespace VLC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Meal> meals { get; set; }

        public DbSet<VLC.Models.MealManager.MealManager> MealManager { get; set; }


    }
}