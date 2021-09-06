using NetChill.Backend.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NetChill.Backend.Presentation.Controllers
{
    public class MoviesController : ApiController
    {
        private readonly MovieBusinessLogic _movieBusinessLogic;

        public MoviesController()
        {
            this._movieBusinessLogic = new MovieBusinessLogic();
        }

        [HttpGet]
        [Route("Movies")]
        public IHttpActionResult GetAllMovies() {
            return Ok(new { Message = "All Movies" });
        }

        [HttpGet]
        [Route("Movies/{id}")]
        public IHttpActionResult GetMovie(Guid id) {
            return Ok(new { Message = id });
        }
    
    }
}