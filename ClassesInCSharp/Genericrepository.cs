using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    class Genericrepository<T>:IRepository<T> where T:Car
    {
        List<T> list ;

        //constructor
        public Genericrepository()
        {
            list = new List<T>();
        }

        public void Delete(T obj)
        {
            list.Remove(obj);
        }

        public T GetByID(int id)
        {
           return list.Find(el => el.ID == id);
           

        }

        public void Insert(T obj)
        {
            list.Add(obj);
        }

        public void Update(T obj)
        {
            list.Insert(list.IndexOf(obj), obj);
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }


    }
}
