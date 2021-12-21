using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ExpenseRepo : IRepository<Expence, int>
    {
        Entities db;
        public ExpenseRepo(Entities db)
        {
            this.db = db;
            db = new Entities();
        }
        public void Add(Expence a)
        {
            db.Expences.Add(a);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var man = db.Expences.FirstOrDefault(e => e.ExpID == id);
            db.Expences.Remove(man);
            db.SaveChanges();
        }
        public void Edit(Expence e)
        {
            var emp = db.Expences.FirstOrDefault(em => em.ExpID == e.ExpID);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }
        public Expence Get(int id)
        {
            return db.Expences.FirstOrDefault(e => e.ExpID == id);
        }

        public List<Expence> GetAll()
        {
            return db.Expences.ToList();
        }
    }
}
