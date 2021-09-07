using System.Collections.Generic;
using System.Web.Http;

namespace NetChill.Backend.Presentation.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
