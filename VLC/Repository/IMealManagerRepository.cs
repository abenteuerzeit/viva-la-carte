using System;
using VLC.Models.MealManager;

namespace VLC.Repository
{
    public interface IMealManagerRepository<TEntity> where TEntity : MealManager
    {
        Task<IEnumerable<MealManager>> GetRecords();
        Task<MealManager> GetRecordByIdAsync(int id, string includeProperties = "");
        Task InsertRecordAsync(MealManager mealManager);
        void UpdateRecord(MealManager mealManager);
        Task DeleteRecordAsync(int mealManagerId);
        Task SaveChangesAsync();
    }
}

