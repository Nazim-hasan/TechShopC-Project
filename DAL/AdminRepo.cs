using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class AdminRepo : IRepository<Admin, int>
    {
        Entities db;
        public AdminRepo(Entities db)
        {
            this.db = db;
            db = new Entities();
        }
        public void Add(Admin a)
        {
            db.Admins.Add(a);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var man = db.Admins.FirstOrDefault(e => e.AdminId == id);
            db.Admins.Remove(man);
            db.SaveChanges();
        }

        public void Edit(Admin e)
        {
            var emp = db.Admins.FirstOrDefault(em => em.AdminId == e.AdminId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(e => e.AdminId == id);
        }

        public List<Admin> GetAll()
        {
            return db.Admins.ToList();
        }
    }
}
