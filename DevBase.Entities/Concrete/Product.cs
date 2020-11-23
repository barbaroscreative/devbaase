using DevBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Entities.Concrete
{
    public class Product:ITable
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }

    }
}
