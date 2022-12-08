using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
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

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

