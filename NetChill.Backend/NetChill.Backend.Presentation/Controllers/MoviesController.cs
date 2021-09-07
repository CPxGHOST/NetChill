using NetChill.Backend.BusinessLogic;
using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NetChill.Backend.Presentation.Controllers
{
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiController
    {
        private readonly MovieBusinessLogic _movieBusinessLogic;

        public MoviesController()
        {
            this._movieBusinessLogic = new MovieBusinessLogic();
        }

        [HttpGet]
        [Route()]
        public IHttpActionResult GetAllMovies() {
            var movies = _movieBusinessLogic.GetAllMovies();
            return Ok(new { Movie = movies});
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetMovie(Guid id) {
            Movie movie = (Movie)_movieBusinessLogic.GetMovieByMovieId(id);
            return Ok(new {SingleMovie = movie});
        }

        [HttpPost]
        [Route()]
        public IHttpActionResult AddMovie(Movie movie) {
            try
            {
                var res = _movieBusinessLogic.AddMovie(movie);
                if (res)
                {
                    return Ok();
                }
                else {
                    return InternalServerError();
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                return InternalServerError(exception);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult UpdateMovie(Guid id) {
            return Ok(new { Movie = "Updated" });
        }
    
    }

}