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
            //Users = new InternalDbSet<User>(this, "Users");
        }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            //Users = new InternalDbSet<User>(this, "Users");
        }

        //public DbSet<User> Users { get; set; }

        public List<User> Users => new List<User>() ?? Users;
        public DbSet<Cart>? Carts { get; set; }
    }

}