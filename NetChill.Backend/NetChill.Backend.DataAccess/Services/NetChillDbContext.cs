using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
{
    public class NetChillDbContext: DbContext
    {
        public DbSet<User> Users { get; set;}

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieList> MovieLists { get; set;}
    }
}
