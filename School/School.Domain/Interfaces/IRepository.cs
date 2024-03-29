﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Interfaces
{
    public interface IRepository<T>
    {
        int Create(T t);
        int Update(T t);
        bool Delete(T t);
        List<T> GetAll();
    }
}
