using System;
using VLC.Models.MealManager;
using VLC.Models.Recipes;
using VLC.Repository;

namespace VLC.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<MealManager> MealManagerRepo { get; }
        IRepository<Hits> RecipesRepo { get; }
        Task SaveChangesAsync();
    }
}

