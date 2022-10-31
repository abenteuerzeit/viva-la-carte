using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MvcVivaLaCarte.Models.Users
{
    public partial class UserDbContext : DbContext
    {
        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public virtual DbSet<User>? Users { get; set; }
    }

    
}