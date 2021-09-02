using NetChill.Backend.Domain;
using System.Collections.Generic;

namespace NetChill.Backend.DataAccess.Services
{
    public interface IMovieDataAccess
    {
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetFeaturedMovies();
        IEnumerable<Movie> GetUpcomingMovies();
        IEnumerable<Movie> GetNewReleases();
    }
}
