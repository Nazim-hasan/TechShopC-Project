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
    public class ManagerSevice
    {
        public static List<ManagerModel>GetAll() {
            var config = new MapperConfiguration(c => c.CreateMap<Manager, ManagerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ManagerModel>>(DataAccessFactory.ManagerDataAccess().GetAll());
            return data;
        }
        public static List<string> GetNames() {
            var data = DataAccessFactory.ManagerDataAccess().GetAll().Select(emp => emp.MName).ToList();
            return data;
        }
        public static void Delete(int id) {
            DataAccessFactory.ManagerDataAccess().Delete(id);
        }
        public static void Add(ManagerModel man)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ManagerModel, Manager>())).Map<Manager>(man);
            DataAccessFactory.ManagerDataAccess().Add(data);
        }
        public static void Edit(ManagerModel man)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ManagerModel, Manager>())).Map<Manager>(man);
            DataAccessFactory.ManagerDataAccess().Edit(data);
        }
        public static ManagerModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ManagerModel>(DataAccessFactory.ManagerDataAccess().Get(id));
            return data;
        }
        //public static void GetAllWithBonus() {}
    }
}
