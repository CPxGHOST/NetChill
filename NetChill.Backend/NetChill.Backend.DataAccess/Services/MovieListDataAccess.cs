using NetChill.Backend.Domain;
using System;

namespace NetChill.Backend.DataAccess.Services
{
    public class MovieListDataAccess : IMovieListDataAccess
    {
        private readonly NetChillDbContext _context;
        public MovieListDataAccess()
        {
            this._context = new NetChillDbContext();
        }
        
        /// <inheritdoc cref="IMovieListDataAccess.AddMovieToMovieList(Movie, User)"/>
        public bool AddMovieToMovieList(Movie movie, User user)
        {
            try
            {
                this._context.MovieLists.Add(new MovieList
                {
                    Movie = movie,
                    User = user,
                    MovieId = movie.Id,
                    UserId = user.Id

                });
                this._context.SaveChanges();
                return true;
            }
            catch (Exception exception) 
            {
                Console.WriteLine(exception);
                return false;
            }
        }
    }

}