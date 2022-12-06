using System;
using VLC.Data;
using VLC.Models.MealManager;
using Microsoft.EntityFrameworkCore;

namespace VLC.Repository
{
    public class MealManagerRepository<TEntity> : IMealManagerRepository<TEntity> where TEntity : MealManager
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<MealManager> _dbSet;
        private bool _disposed = false;

        public MealManagerRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<MealManager>();
        }

        public async Task<IEnumerable<MealManager>> GetRecords()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<MealManager> GetRecordByIdAsync(int id, string includeProperties = "")
        {
            IQueryable<MealManager> query = _dbSet;
            query = includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, prop) => current.Include(prop));
            return await query.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertRecordAsync(MealManager mealManager)
        {
            await _dbSet.AddAsync(mealManager);
        }

        public void UpdateRecord(MealManager mealManager)
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

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                this._disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MealManagerRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        
    }
}

