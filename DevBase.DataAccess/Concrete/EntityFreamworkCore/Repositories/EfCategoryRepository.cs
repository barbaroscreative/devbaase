using DevBase.DataAccess.Concrete.EntityFreamworkCore.Contexts;
using DevBase.DataAccess.Interfaces;
using DevBase.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBase.DataAccess.Concrete.EntityFreamworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public List<Category> GetProductSuccess()
        {
            using (var context = new DevBaseContext())
            {
               return context.Categories.Include(I => I.Product).OrderByDescending(I => I.Name).ToList();
            }
        }
    }
}
