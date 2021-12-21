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
    public class ExpenceController : ApiController
    {
        [Route("api/Expense/All")]
        [HttpGet]
        public List<ExpenseModel> GetAll()
        {
            return ExpenseService.GetAll();
        }

        [Route("api/Expense/edit")]
        [HttpPost]
        public void edit(ExpenseModel man)
        {
            ExpenseService.Edit(man);
        }
        [Route("api/Expense/get/{id}")]
        [HttpGet]
        public ExpenseModel Get(int id)
        {
            return ExpenseService.Get(id);
        }
    }
}
