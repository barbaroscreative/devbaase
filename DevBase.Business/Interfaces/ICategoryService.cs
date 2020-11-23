using DevBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Business.Interfaces
{
    public interface ICategoryService : IGenericService<Category>
    {
        List<Category> GetProductSuccess();
    }
}
