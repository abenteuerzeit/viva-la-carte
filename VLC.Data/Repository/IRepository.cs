using System;
using VLC.Models.Entity;
using VLC.Models.MealManager;

namespace VLC.Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetRecordByIdAsync(int id, string includeProperties = "");
        Task InsertRecordAsync(TEntity entity);
        void UpdateRecord(TEntity entity);
        Task DeleteRecordAsync(int entity);
        Task SaveChangesAsync();
    }
}

