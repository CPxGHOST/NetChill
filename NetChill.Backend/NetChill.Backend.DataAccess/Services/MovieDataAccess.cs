using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetChill.Backend.DataAccess.Services
{
    public class MovieDataAccess : IMovieDataAccess
    {

        private readonly NetChillDbContext _context;

        public MovieDataAccess()
        {
            this._context = new NetChillDbContext();
        }
        public IEnumerable<Movie> GetAllMovies()
        {
            return this._context.Movies.OrderBy(movie => movie.AvailabilityStarts);
        }

        public IEnumerable<Movie> GetFeaturedMovies()
        {
            return (IEnumerable<Movie>)this._context.Movies.Select(movie => movie.IsFeatured == true);
        }

        public IEnumerable<Movie> GetNewReleases()
        {
            var query = from movie in this._context.Movies
                        where movie.AvailabilityStarts <= DateTime.Now
                        orderby movie.AvailabilityStarts descending
                        select movie;
            return query;
        }

        public IEnumerable<Movie> GetUpcomingMovies()
        {

            var query = from movie in this._context.Movies
                        where movie.AvailabilityStarts > DateTime.Now
                        select movie;

            return query;
        }
    }
}
