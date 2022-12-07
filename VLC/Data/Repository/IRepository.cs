using System;
using VLC.Models.Entity;
using VLC.Models.MealManager;

namespace VLC.Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetRecordByIdAsync(int id, string includeProperties = "");
        Task InsertRecordAsync(TEntity mealManager);
        void UpdateRecord(TEntity mealManager);
        Task DeleteRecordAsync(int mealManagerId);
        Task SaveChangesAsync();
    }
}

