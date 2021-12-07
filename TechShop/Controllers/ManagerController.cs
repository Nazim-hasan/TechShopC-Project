using BEL;
using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TechShop.Controllers
{
    public class ManagerController : ApiController
    {
        [Route("api/Manager/All")]
        [HttpGet]
        public List<ManagerModel> GetAll() {
            return ManagerSevice.GetAll();
        }
        [Route("api/Manager/Names")]
        [HttpGet]
        public List<String> Names() {
            return ManagerSevice.GetNames();
        }
        [Route("api/Manager/delete/{id}")]
        [HttpPost]
        public void delete(int id)
        {
            ManagerSevice.Delete(id);
        }

        [Route("api/Manager/add")]
        [HttpPut]

        public void add(ManagerModel man)
        {
            ManagerSevice.Add(man);
        }
        

    }
}
