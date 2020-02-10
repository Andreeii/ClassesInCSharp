using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    public abstract class Car
    {
       
        public readonly static short wheel_number;
        public Car() { }
         static Car()
        {
            wheel_number = 4;
            Console.WriteLine("number of wheels is :"+ wheel_number);
        }
        public int enginepower { get; set; }
        public double engineVolume { get; set; }
        public string color { get; set; }
        public int fuelPerKm { get; set; }
        

        public Car(int enginepower, double engineVolume, string color)
        {
            this.enginepower = enginepower;
            this.engineVolume = engineVolume;
            this.color = color;
        }

        public virtual double Price(Fuel f)
        {
            double price;
            if (f.fueltype == type.diesel)
            {
                price = enginepower * (int)engineVolume  * 1.3;
            }
            else
            {
                price = enginepower * (int)engineVolume  * 1.5;
            }
            return price;
        }
    }
}
