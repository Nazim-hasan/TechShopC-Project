using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExpenseService
    {
        public static List<ExpenseModel> GetAll()
        {
            var config = new MapperConfiguration(cf => cf.CreateMap<Expence, ExpenseModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ExpenseModel>>(DataAccessFactory.ExpenseDataAccess().GetAll());
            return data;
        }
        public static ExpenseModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Expence, ExpenseModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ExpenseModel>(DataAccessFactory.ExpenseDataAccess().Get(id));
            return data;
        }
        public static void Edit(ExpenseModel man)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ExpenseModel, Expence>())).Map<Expence>(man);
            DataAccessFactory.ExpenseDataAccess().Edit(data);
        }
    }
}
