using NetChill.Server.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Server.DataAccess.Services
{
    public class MovieDataAccess : IMovieDataAccess
    {

        private readonly NetChillDbContext netChillContext;


        
        public MovieDataAccess()
        {
            this.netChillContext = new NetChillDbContext();
        }

        /// <inheritdoc cref="IMovieDataAccess.GetAllMovies"/>
        public IEnumerable<Movie> GetAllMovies()
        {
            try {
                return this.netChillContext.Movies.OrderBy(movie => movie.AvailabilityStarts);
            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return null;
            }
          
        }

        /// <inheritdoc cref="IMovieDataAccess.GetFeaturedMovies"/>
        public IEnumerable<Movie> GetFeaturedMovies()
        {
            try
            {
                return (IEnumerable<Movie>)this.netChillContext.Movies.Select(movie => movie.IsFeatured == true);
            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return null;
            }
            
        }

        /// <inheritdoc cref="IMovieDataAccess.GetNewReleases"/>
        public IEnumerable<Movie> GetNewReleases()
        {
            try
            {
                var query = from movie in this.netChillContext.Movies
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
                var query = from movie in this.netChillContext.Movies
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
