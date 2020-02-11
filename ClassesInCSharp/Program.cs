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
            BMW bmwx5 = new BMW(6, 3.5, "blue", 1500);

            Console.WriteLine("Calculating price for bmwx3: "+bmwx3.Price(fuel1));
            Console.WriteLine("Calculating price for bmwx5: " + bmwx5.Price());
            
        }
    }
}
