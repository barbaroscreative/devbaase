using DevBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Entities.Concrete
{
    public class Category:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
