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
    public class BonusService
    {
        public static List<BonusModel> GetAll()
        {
            var config = new MapperConfiguration(cf => cf.CreateMap<Bonu, BonusModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BonusModel>>(DataAccessFactory.BonusDataAccess().GetAll());
            return data;
        }
        public static void Delete(int id)
        {
            DataAccessFactory.BonusDataAccess().Delete(id);
        }
        public static void Add(BonusModel man)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<BonusModel, Bonu>())).Map<Bonu>(man);
            DataAccessFactory.BonusDataAccess().Add(data);
        }
    }
}
