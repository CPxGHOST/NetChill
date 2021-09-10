using NetChill.Backend.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NetChill.Backend.Presentation.Controllers
{
    [RoutePrefix("api/upcoming")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UpcomingMoviesController : ApiController
    {
        private readonly MovieBusinessLogic _movieBusinessLogic;
        public UpcomingMoviesController()
        {
            this._movieBusinessLogic = new MovieBusinessLogic();
        }

        [HttpGet]
        [Route()]
        public IHttpActionResult GetUpcomingMovies() {
            try
            {
                var upcomingMovies = this._movieBusinessLogic.GetUpcomingMovies();
                if (upcomingMovies != null)
                {
                    return Ok(upcomingMovies);
                }
                else {
                    return NotFound();
                }

            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return InternalServerError();
            }
            
        }
    }
}