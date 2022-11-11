using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VLC.Models.MealManager;
using VLC.Models.Meals;
using VLC.Models.Recipes;

namespace VLC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<MealManager>? MealManagers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MealPlan>()
        //    .HasMany(p => p.Recipes);
        //    //.WithOne()
        //    //.WithOne(g => g.).HasForeignKey(s => s)
        //    //.OnDelete(DeleteBehavior.Cascade);
        //}
    }
}