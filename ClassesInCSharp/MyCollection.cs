using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    class MyCollection<T> : IEnumerable
    {
        private T[] arr;

        public int Size
        {
            get
            {
                return arr.Length;
            }
        }

        public MyCollection() : this(10) { }

        public MyCollection(int Size)
        {
            arr = new T[Size];
        }

        public void Add(T item, int index)
        {
            if (index > arr.Length - 1)
            {
                T[] temp = new T[arr.Length * (index / arr.Length * 2)];
                arr.CopyTo(temp, 0);
                arr = temp;
                arr[index] = item;
            }
            else
            {
                arr[index] = item;
            }
        }
        public T Get(int index)
        {
            return arr[index];
        }
        public void Swap(int index1, int index2)
        {
            T temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }

    
        //public void Swap(T item1, T item2)
        //{
        //    T temp;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i].Equals(item1))
        //        {
        //            temp = arr[i];
        //            for (int j = 0; j < arr.Length; j++)
        //            {
        //                if (arr[j].Equals(item2))
        //                {
        //                    arr[i] = arr[j];
        //                    arr[j] = temp;
        //                    break;
        //                }
        //                break;
        //            }

        //        }
        //    }
        //}


    }
}
