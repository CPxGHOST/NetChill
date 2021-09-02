using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
{
    public interface IMovieListDataAccess
    {
        /// <summary>
        /// Adds a movie to the list for the corresponding user
        /// </summary>
        /// <param name="movie">Movie to be added</param>
        /// <param name="user">User that adds the movie</param>
        /// <returns>true if sucessfully added else false</returns>
        bool AddMovieToMovieList(Movie movie , User user);
    }
}
