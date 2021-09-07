using NetChill.Backend.DataAccess.Services;
using NetChill.Backend.Domain;
using System;
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

        public Movie GetMovieByMovieId(Guid id)
        {
            return _movieDataAccess.GetMovieByMovieId(id);
        }

        public bool AddMovie(Movie movie) {
            return _movieDataAccess.AddMovie(movie);
        }

        public bool UpdateMovie(Movie newMovie) {
            return _movieDataAccess.UpdateMovie(newMovie);
        }
    
    }
}
