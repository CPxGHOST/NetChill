using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
{
    public class MovieListDataAccess : IMovieListDataAccess
    {
        private readonly NetChillDbContext _netChillDbContext;
        public MovieListDataAccess()
        {
            this._netChillDbContext = new NetChillDbContext();
        }
        
        /// <inheritdoc cref="IMovieListDataAccess.AddMovieToMovieList(Movie, User)"/>
        public bool AddMovieToMovieList(Movie movie, User user)
        {
            try
            {
                this._netChillDbContext.MovieLists.Add(new MovieList
                {
                    Movie = movie,
                    User = user,
                    MovieId = movie.Id,
                    UserId = user.Id

                });
                this._netChillDbContext.SaveChanges();
                return true;
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                return false;
            }
        }
    }

}