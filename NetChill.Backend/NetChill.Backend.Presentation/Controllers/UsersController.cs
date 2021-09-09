using NetChill.Backend.BusinessLogic;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NetChill.Backend.Presentation.Controllers
{
    [EnableCors(origins: "*"  , headers:"*" , methods:"*")]
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly UserBusinessLogic _userBusinessLogic;

        public UsersController()
        {
            _userBusinessLogic = new UserBusinessLogic();
        }

        [HttpGet]
        [Route()]
        public IHttpActionResult GetAllUsers()
        {
            var result = _userBusinessLogic.GetAllUsers();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetUser(Guid id)
        {
            var result = _userBusinessLogic.GetUser(id);

            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
