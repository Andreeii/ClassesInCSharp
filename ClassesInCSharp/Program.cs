using System;

namespace ClassesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuel fuel1= new Fuel(type.diesel, 15);
            Fuel fuel2= new Fuel(type.benzin, 12);


            BMW bmwx3 = new BMW(5, 3.5,"red",1000);

            Console.WriteLine("price for this car is "+bmwx3.Price(fuel1));
            
        }
    }
}
