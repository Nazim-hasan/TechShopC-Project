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
    public class AdminService
    {
        public static List<AdminModel> GetAll()
        {
            var config = new MapperConfiguration(cf => cf.CreateMap<Admin, AdminModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AdminModel>>(DataAccessFactory.AdminDataAccess().GetAll());
            return data;
        }
        
        public static void Delete(int id)
        {
            DataAccessFactory.AdminDataAccess().Delete(id);
        }
        public static void Add(AdminModel man)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(man);
            DataAccessFactory.AdminDataAccess().Add(data);
        }
        public static void Edit(AdminModel man)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(man);
            DataAccessFactory.AdminDataAccess().Edit(data);
        }
        public static AdminModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<AdminModel>(DataAccessFactory.AdminDataAccess().Get(id));
            return data;
        }
    }
}
