using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    interface IRepository<T>
    {

        public abstract T GetByID(int id);
        public abstract void Insert(T obj);

        public abstract void Update(T obj);
        public abstract void Delete(T obj);

        public IEnumerable<T> GetAll();

    }
}
