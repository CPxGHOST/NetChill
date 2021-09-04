using NetChill.Backend.DataAccess.Services;
using NetChill.Backend.Domain;

namespace NetChill.Backend.BusinessLogic
{
    class MovieListBusinessLogic
    {
        private readonly MovieListDataAccess _movieListDataAcces;

        public MovieListBusinessLogic()
        {
            _movieListDataAcces = new MovieListDataAccess();
        }

        public bool AddMovieToMovieList(Movie movie, User user)
        {
            return _movieListDataAcces.AddMovieToMovieList(movie,user);
        }
    }
}
