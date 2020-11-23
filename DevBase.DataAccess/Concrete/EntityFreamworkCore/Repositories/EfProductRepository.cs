using DevBase.DataAccess.Interfaces;
using DevBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.DataAccess.Concrete.EntityFreamworkCore.Repositories
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductDal
    {

    }
}
