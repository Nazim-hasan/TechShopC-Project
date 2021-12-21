using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BonusRepo : IRepository<Bonu, int>
    {
        Entities db;
        public BonusRepo(Entities db)
        {
            this.db = db;
            db = new Entities();
        }
        public void Add(Bonu a)
        {
            db.Bonus.Add(a);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var man = db.Bonus.FirstOrDefault(e => e.BonusId == id);
            db.Bonus.Remove(man);
            db.SaveChanges();
        }
        public void Edit(Bonu e)
        {
            var emp = db.Bonus.FirstOrDefault(em => em.BonusId == e.BonusId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }
        public Bonu Get(int id)
        {
            return db.Bonus.FirstOrDefault(e => e.BonusId == id);
        }

        public List<Bonu> GetAll()
        {
            return db.Bonus.ToList();
        }
    }
}
