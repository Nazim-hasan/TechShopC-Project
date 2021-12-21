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
        [HttpPost]

        public void add(ManagerModel man)
        {
            ManagerSevice.Add(man);
        }
        [Route("api/Manager/edit")]
        [HttpPost]
        public void edit(ManagerModel man)
        {
            ManagerSevice.Edit(man);
        }
        [Route("api/Manager/get/{id}")]
        [HttpGet]
        public ManagerModel Get(int id)
        {
            return ManagerSevice.Get(id);
        }



    }
}
