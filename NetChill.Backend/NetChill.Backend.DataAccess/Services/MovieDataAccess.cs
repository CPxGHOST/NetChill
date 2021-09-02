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

        /// <inheritdoc cref="IMovieDataAccess.GetAllMovies"/>
        public IEnumerable<Movie> GetAllMovies()
        {
            try {
                return this._context.Movies.OrderBy(movie => movie.AvailabilityStarts);
            }
            catch (Exception exception) 
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        /// <inheritdoc cref="IMovieDataAccess.GetFeaturedMovies"/>
        public IEnumerable<Movie> GetFeaturedMovies()
        {
            try
            {
                return (IEnumerable<Movie>)this._context.Movies.Select(movie => movie.IsFeatured == true);
            }
            catch (Exception exception) 
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        /// <inheritdoc cref="IMovieDataAccess.GetNewReleases"/>
        public IEnumerable<Movie> GetNewReleases()
        {
            try
            {
                 var query = from movie in this._context.Movies
                        where movie.AvailabilityStarts <= DateTime.Now
                        orderby movie.AvailabilityStarts descending
                        select movie;
                 return query;
            
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        /// <inheritdoc cref="IMovieDataAccess.GetUpcomingMovies"/>
        public IEnumerable<Movie> GetUpcomingMovies()
        {
            try
            {
                var query = from movie in this._context.Movies
                        where movie.AvailabilityStarts > DateTime.Now
                        select movie;
                return query;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
    }
}
