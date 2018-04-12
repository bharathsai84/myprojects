using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GVOne.Controllers
{
    [Authorize (Roles ="Admin")]
    public class AdminController : ApiController
    {
        public string Gt()
        {
            return "Admin";
        }
    }
}
