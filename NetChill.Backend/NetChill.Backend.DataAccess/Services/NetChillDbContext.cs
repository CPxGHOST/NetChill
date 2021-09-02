using NetChill.Server.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace NetChill.Server.DataAccess.Services
{
    public class NetChillDbContext: DbContext
    {
        public DbSet<User> Users { get; set;}

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieList> MovieLists { get; set;}
    }
}
