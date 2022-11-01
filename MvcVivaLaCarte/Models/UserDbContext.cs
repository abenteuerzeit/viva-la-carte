using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using MvcVivaLaCarte.Models.Carts;
using MvcVivaLaCarte.Models.Users;

namespace MvcVivaLaCarte.Models
{
    public partial class UserDbContext : DbContext
    {
        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Cart>? Carts { get; set; }
    }

}