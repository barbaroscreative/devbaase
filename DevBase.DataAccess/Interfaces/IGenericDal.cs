﻿using DevBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.DataAccess.Interfaces
{
    public interface IGenericDal<Table> where Table : class, ITable, new()
    {
        void Save(Table table);
        void Delete(Table table);
        void Update(Table table);
        Table GetId(int id);
        List<Table> GetAll();
    }
}
