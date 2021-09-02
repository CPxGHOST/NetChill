using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
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
            return this.netChillContext.Movies.OrderBy(movie => movie.AvailabilityStarts);
        }

        /// <inheritdoc cref="IMovieDataAccess.GetFeaturedMovies"/>
        public IEnumerable<Movie> GetFeaturedMovies()
        {
            return (IEnumerable<Movie>)this.netChillContext.Movies.Select(movie => movie.IsFeatured == true);
        }

        /// <inheritdoc cref="IMovieDataAccess.GetNewReleases"/>
        public IEnumerable<Movie> GetNewReleases()
        {
            var query = from movie in this.netChillContext.Movies
                        where movie.AvailabilityStarts <= DateTime.Now
                        orderby movie.AvailabilityStarts descending
                        select movie;
            
            return query;
        }

        /// <inheritdoc cref="IMovieDataAccess.GetUpcomingMovies"/>
        public IEnumerable<Movie> GetUpcomingMovies()
        {

            var query = from movie in this.netChillContext.Movies
                        where movie.AvailabilityStarts > DateTime.Now
                        select movie;

            return query;
        }
    }
}
