using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuel fuel1 = new Fuel(type.diesel, 15);
            Fuel fuel2 = new Fuel(type.benzin, 12);


            var car1 = new BMW(1,"bmwx3",5, 3.5, "red", 1000);
            var car2 = new BMW(2,"bmwx5", 6, 3.5, "blue", 1500);
            var car3 = new BMW(3,"bmwx6", 7, 4.5, "green", 2000);
            var car4 = new BMW(4,"bmwx7", 7, 4.5, "green", 2500);

            // Console.WriteLine(car1.Name +":"+ car1.Price());
            // Console.WriteLine(car3.Name+":"+ car3.Price());
            // Console.WriteLine(car4.Name +":"+ car4.Price(fuel1));



            // //adding collections
            //List<Car> depozit = new List<Car>(3);

            // depozit.Add(car1);
            // depozit.Add(car2);
            // depozit.Add(car3);


            // foreach(var car in depozit)
            // {
            //     Console.WriteLine(car);
            // }

            // Dictionary<string,Car> autosalon = new Dictionary<string,Car>();

            // autosalon.Add("model1", car1);
            // autosalon.Add("model2", car2);
            // autosalon.Add("model3", car3);
            // autosalon.Add("model4", car4);

            // foreach(var car in autosalon)
            // {
            //     Console.WriteLine(car);
            // }

            IEnumerable<BMW> list2 = new List<BMW>();

            Genericrepository<BMW> genericrepository = new Genericrepository<BMW>();

            genericrepository.Insert(car1);
            genericrepository.Insert(car2);
            genericrepository.Insert(car3);
            genericrepository.Insert(car4);


            //genericrepository.Delete(car1);

            //Console.WriteLine( genericrepository.GetByID(3));


           // genericrepository.Update(car4);

            list2 = genericrepository.GetAll();

            foreach(var car in list2)
            {
                Console.WriteLine(car);
            }


          






            //MyCollection<string> list1 = new MyCollection<string>();
            //list1.Add("str1", 0);
            //list1.Add("str2", 1);
            //list1.Add("str3", 2);
            //list1.Add("str4", 20);


            //list1.Swap(0, 20);
            //Console.WriteLine(list1.Get(20));
            //Console.WriteLine(list1.Size);


            //foreach (var i in list1)
            //{
            //    Console.WriteLine(i);
            //}






        }
    }
}
