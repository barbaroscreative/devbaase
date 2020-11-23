using DevBase.Business.Interfaces;
using DevBase.DataAccess.Concrete.EntityFreamworkCore.Repositories;
using DevBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void Delete(Category table)
        {
            efCategoryRepository.Delete(table);
        }

        public List<Category> GetAll()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetId(int id)
        {
            return efCategoryRepository.GetId(id);
        }

        public List<Category> GetProductSuccess()
        {
            return efCategoryRepository.GetProductSuccess();
        }

        public void Save(Category table)
        {
            efCategoryRepository.Save(table);
        }

        public void Update(Category table)
        {
            efCategoryRepository.Update(table);
        }
    }
}
