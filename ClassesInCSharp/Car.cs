using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    public abstract class Car
    {
        public int Enginepower { get; set; }
        public double EngineVolume { get; set; }
        public string Color { get; set; }
        public int ID;
        public string Name { get; set; }
        public readonly static short wheel_number;
        public Car() { }

        static Car()
        {
            wheel_number = 4;
            Console.WriteLine("number of wheels is :"+ wheel_number);
        }
       

        public Car(string name,int enginepower, double engineVolume, string color)
        {
            this.Name = name;
            this.Enginepower = enginepower;
            this.EngineVolume = engineVolume;
            this.Color = color;
        }

        public virtual double Price(Fuel f)
        {
            double price;
            if (f.fueltype == type.diesel)
            {
                price = Enginepower * (int)EngineVolume  * 1.3;
            }
            else
            {
                price = Enginepower * (int)EngineVolume  * 1.5;
            }
            return price;
        }

 
    }
}
