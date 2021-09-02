using NetChill.Backend.Domain;
using System.Data.Entity;

namespace NetChill.Backend.DataAccess.Services
{
    public class NetChillDbContext: DbContext
    {
        public DbSet<User> Users { get; set;}

        public DbSet<Movie> Movies { get; set; }
    }
}
