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
    public class BonusController : ApiController
    {
        [Route("api/Bonus/All")]
        [HttpGet]
        public List<BonusModel> GetAll()
        {
            return BonusService.GetAll();
        }

        [Route("api/Bonus/add")]
        [HttpPost]

        public void add(BonusModel man)
        {
            BonusService.Add(man);
        }

        [Route("api/Bonus/delete/{id}")]
        [HttpPost]
        public void delete(int id)
        {
            BonusService.Delete(id);
        }
    }
}
