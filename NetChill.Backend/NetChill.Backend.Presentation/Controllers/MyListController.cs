using NetChill.Backend.BusinessLogic;
using NetChill.Backend.Domain;
using NetChill.Backend.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NetChill.Backend.Presentation.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/mylist")]
    public class MyListController : ApiController
    {
        private readonly MovieListBusinessLogic _movieListBusinessLogic;

        private readonly UserBusinessLogic _userBusinessLogic;

        private readonly MovieBusinessLogic _movieBusinessLogic;
        
        public MyListController()
        {
            this._movieListBusinessLogic = new MovieListBusinessLogic();
            this._movieBusinessLogic = new MovieBusinessLogic();
            this._userBusinessLogic = new UserBusinessLogic();
        }

        [Route()]
        [HttpPost]
        public IHttpActionResult AddToMyList(AddToMyListModel addToMyListModel)
        {
            try
            {
                User user = this._userBusinessLogic.GetUser(addToMyListModel.UserId);
                Movie movie = this._movieBusinessLogic.GetMovieByMovieId(addToMyListModel.MovieId);
                bool result = this._movieListBusinessLogic.AddMovieToMovieList(movie, user);
                if (result)
                {
                    return Ok();
                }
                else {
                    return NotFound();
                }    

            }
            catch(Exception exception) {
                Console.WriteLine(exception.Message);
                return InternalServerError();
            }
        
        }
    
    }
}