using DevBase.Business.Interfaces;
using DevBase.DataAccess.Concrete.EntityFreamworkCore.Repositories;
using DevBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly EfProductRepository efProductRepository;
        public ProductManager()
        {
            efProductRepository = new EfProductRepository();
        }
        public void Delete(Product table)
        {
            efProductRepository.Delete(table);
        }

        public List<Product> GetAll()
        {
            return efProductRepository.GetAll();
        }

        public Product GetId(int id)
        {
            return efProductRepository.GetId(id);
        }

        public void Save(Product table)
        {
            efProductRepository.Save(table);
        }

        public void Update(Product table)
        {
            efProductRepository.Update(table);
        }
    }
}
