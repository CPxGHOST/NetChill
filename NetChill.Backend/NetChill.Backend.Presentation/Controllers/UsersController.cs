using NetChill.Backend.BusinessLogic;
using NetChill.Backend.Domain;
using System;
using System.Web.Http;

namespace NetChill.Backend.Presentation.Controllers
{
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

        [HttpPost]
        [Route()]
        public IHttpActionResult SignUp(User user)
        {
            try
            {
                var userExists = _userBusinessLogic.GetUser(user.Email);

                if (userExists != null)
                {
                    return InternalServerError();
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        User newUser = new User
                        {
                            FullName = user.FullName,
                            Email = user.Email,
                            Password = user.Password,
                            Role = user.Role
                        };

                        _userBusinessLogic.AddUser(newUser);
                        return Ok();
                    }
                }
                
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }

            return BadRequest(ModelState);
        }
    }
}
