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

        private readonly NetChillDbContext movieData;

        public MovieDataAccess()
        {
            this.movieData = new NetChillDbContext();
        }
        public IEnumerable<Movie> GetAllMovies()
        {
            return this.movieData.Movies.OrderBy(movie => movie.AvailabilityStarts);
        }

        public IEnumerable<Movie> GetFeaturedMovies()
        {
            return (IEnumerable<Movie>)this.movieData.Movies.Select(movie => movie.IsFeatured == true);
        }

        public IEnumerable<Movie> GetNewReleases()
        {
            var query = from movie in this.movieData.Movies
                        where movie.AvailabilityStarts <= DateTime.Now
                        orderby movie.AvailabilityStarts descending
                        select movie;
            return query;
        }

        public IEnumerable<Movie> GetUpcomingMovies()
        {

            var query = from movie in this.movieData.Movies
                        where movie.AvailabilityStarts > DateTime.Now
                        select movie;

            return query;
        }
    }
}
