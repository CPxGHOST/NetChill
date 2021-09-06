using NetChill.Backend.DataAccess.Services;
using NetChill.Backend.Domain;
using System.Collections.Generic;

namespace NetChill.Backend.BusinessLogic
{
   public class MovieBusinessLogic
    {
        private readonly MovieDataAccess _movieDataAccess;

        public MovieBusinessLogic()
        {
            _movieDataAccess = new MovieDataAccess();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movieDataAccess.GetAllMovies();
        }

        public IEnumerable<Movie> GetFeaturedMovies()
        {
            return _movieDataAccess.GetFeaturedMovies();
        }

        public IEnumerable<Movie> GetUpcomingMovies()
        {
            return _movieDataAccess.GetUpcomingMovies();
        }

        public IEnumerable<Movie> GetNewReleases()
        {
            return _movieDataAccess.GetNewReleases();
        }

    }
}
