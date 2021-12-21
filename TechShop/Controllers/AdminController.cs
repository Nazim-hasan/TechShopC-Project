using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TechShop.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        [Route("api/Admin/get/{id}")]
        [HttpGet]
        public AdminModel Get(int id)
        {
            return AdminService.Get(id);
        }
    }
}
