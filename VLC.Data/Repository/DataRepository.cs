using System;
using Microsoft.EntityFrameworkCore;
using VLC.Data;
using VLC.Models.Entity;
using VLC.Models.MealManager;

namespace VLC.Repository
{
    public class DataRepository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public DataRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }


        public async Task<TEntity> GetRecordByIdAsync(int id, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;
            query = includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, prop) => current.Include(prop));
            return await query.SingleOrDefaultAsync(x => x.Id == id);
        }
    


        public async Task InsertRecordAsync(TEntity mealManager)
        {
            await _dbSet.AddAsync(mealManager);
        }


        public void UpdateRecord(TEntity mealManager)
        {
            _context.Entry(mealManager).State = EntityState.Modified;
        }


        public async Task DeleteRecordAsync(int mealManagerId)
        {
            var entity = await _dbSet.FindAsync(mealManagerId);
            _dbSet.Remove(entity);
        }

        

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

