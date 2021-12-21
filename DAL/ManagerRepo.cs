using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerRepo : IRepository<Manager, int>
    {
        Entities db;
        public ManagerRepo(Entities db) 
        {
            this.db = db;
            db = new Entities();
        }

        public void Add(Manager e)
        {
            db.Managers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var man = db.Managers.FirstOrDefault(e => e.MId == id);
            db.Managers.Remove(man);
            db.SaveChanges();
        }

        public void Edit(Manager e)
        {
            var emp = db.Managers.FirstOrDefault(em => em.MId == e.MId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Manager Get(int id)
        {
            return db.Managers.FirstOrDefault(e => e.MId == id);
        }

        public List<Manager> GetAll()
        {
            return db.Managers.ToList();
        }
    }
}
