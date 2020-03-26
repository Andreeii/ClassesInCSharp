using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var hammer = new ArmyCar()
            {
                Colour = "Yellow",
                Price = 20000,
                Engine = new DieselEngine()
                {
                    EngineVolume = 3.2,
                    BrandName = "v6",
                    FuelType = new Fuel(diesel,12),

                }
            };


            

            using (var contextC = new CarContext())
            {



                contextC.SaveChanges();
            }

    }

    }
}

