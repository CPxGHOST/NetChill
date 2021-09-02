using NetChill.Server.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Server.DataAccess.Services
{
    public interface IMovieDataAccess
    {

        /// <summary>
        ///  Finds all movies in ascending order of their dates
        /// </summary>
        /// <returns>Returns an enumerable containing all the movies</returns>
        IEnumerable<Movie> GetAllMovies();

        /// <summary>
        /// Finds all the featured movies
        /// </summary>
        /// <returns>All Featured Movies</returns>
        IEnumerable<Movie> GetFeaturedMovies();

        /// <summary>
        /// Finds those movies whose dates are in the future
        /// </summary>
        /// <returns>All the upcoming movies</returns>
        IEnumerable<Movie> GetUpcomingMovies();

        /// <summary>
        /// Finds the latest released movies
        /// </summary>
        /// <returns>An enumerable having all the latest movies</returns>
        IEnumerable<Movie> GetNewReleases();
    }
}
