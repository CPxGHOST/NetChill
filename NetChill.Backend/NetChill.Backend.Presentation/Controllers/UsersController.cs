using NetChill.Backend.DataAccess.Services;
using System.Web.Http;

namespace NetChill.Backend.Presentation.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserDataAccess _userDataAccess;

        public UsersController(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public IHttpActionResult GetAllUsers()
        {
            var result = _userDataAccess.GetAllUsers();
            return Ok(result);
        }
    }
}
