using System;
using VLC.Models.MealManager;
using VLC.Models.Recipes;
using VLC.Repository;

namespace VLC.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;

        public IRepository<MealManager> MealManagerRepo { get; }

        //private bool disposedValue;

        public UnitOfWork(ApplicationDbContext context, IRepository<MealManager> mealManagerRepo)
        {
            _context = context;
            MealManagerRepo = mealManagerRepo;
        }


        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();

            //if (!disposedValue)
            //{
            //    if (disposing)
            //    {
            //        // TODO: dispose managed state (managed objects)
            //    }

            //    // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            //    // TODO: set large fields to null
            //    disposedValue = true;
            //}
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
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

