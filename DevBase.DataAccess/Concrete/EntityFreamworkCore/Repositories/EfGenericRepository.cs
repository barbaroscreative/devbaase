using DevBase.DataAccess.Concrete.EntityFreamworkCore.Contexts;
using DevBase.DataAccess.Interfaces;
using DevBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBase.DataAccess.Concrete.EntityFreamworkCore.Repositories
{
    public class EfGenericRepository<Table> : IGenericDal<Table> where Table : class, ITable, new()
    {
        public void Delete(Table table)
        {
            using var context = new DevBaseContext();
            context.Set<Table>().Remove(table);
            context.SaveChanges();
        }

        public List<Table> GetAll()
        {
            using var context = new DevBaseContext();
            return context.Set<Table>().ToList();
        }

        public Table GetId(int id)
        {
            using var context = new DevBaseContext();
            return context.Set<Table>().Find(id);
        }

        public void Save(Table table)
        {
            using var context = new DevBaseContext();
            context.Set<Table>().Add(table);
            context.SaveChanges();
        }

        public void Update(Table table)
        {
            using var context = new DevBaseContext();
            context.Set<Table>().Update(table);
            context.SaveChanges();
            //context.Entry(table).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        }
    }
}
