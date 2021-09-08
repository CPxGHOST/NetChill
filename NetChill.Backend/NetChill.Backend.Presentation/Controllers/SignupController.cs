using NetChill.Backend.BusinessLogic;
using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NetChill.Backend.Presentation.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/signup")]
    public class SignupController : ApiController
    {
        private readonly UserBusinessLogic _userBusinessLogic;

        public SignupController()
        {
            _userBusinessLogic = new UserBusinessLogic();
        }

        [HttpPost]
        [Route()]
        public IHttpActionResult SignUp(User user)
        {
            try
            {
                var userExists = _userBusinessLogic.GetUserByEmail(user.Email);

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
                    else
                    {
                        return BadRequest();
                    }
                }

            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }

        }
    }
}
