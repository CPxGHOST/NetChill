using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
