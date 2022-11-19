using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NuGet.Protocol;
using System.Data;
using VLC.Models.API;
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

        public DbSet<Hits> RecipeSearches { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Cookbook> Cookbooks { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<MealManager> MealManagers { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MealPlan>()
        //    .HasMany(p => p.Recipes);
        //    //.WithOne()
        //    //.WithOne(g => g.).HasForeignKey(s => s)
        //    //.OnDelete(DeleteBehavior.Cascade);
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    //modelBuilder.Entity<string[]>()
        //    //            .Property(e => e)
        //    //            .HasConversion(
        //    //                v => string.Join(',', v),
        //    //                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        //    //modelBuilder.Entity<DataSet>()
        //    //            .Property(d => d.SemanticType)
        //    //            .HasConversion(new EnumToStringConverter<DataSetSemanticType>());
        //}


        public async ValueTask<MealPlan> FindMealPlanAsync(int id)
        {
            MealPlan plan = await MealPlans.FindAsync(id);

            return plan;
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MealPlan>()
        //    .HasMany(p => p.Recipes);
        //    //.WithOne()
        //    //.WithOne(g => g.).HasForeignKey(s => s)
        //    //.OnDelete(DeleteBehavior.Cascade);
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    //modelBuilder.Entity<string[]>()
        //    //            .Property(e => e)
        //    //            .HasConversion(
        //    //                v => string.Join(',', v),
        //    //                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        //    //modelBuilder.Entity<DataSet>()
        //    //            .Property(d => d.SemanticType)
        //    //            .HasConversion(new EnumToStringConverter<DataSetSemanticType>());
        //}


        public DbSet<VLC.Models.Recipes.Hit> Hit { get; set; }
    }
}