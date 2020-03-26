using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var bmwx3 = new BMW
            {
                Color = "Green",
                Name = "bmwx6",
                Enginepower = 234,
                EngineVolume = 3.2,
                designcost = 5000,
                BMWCharacteristic1 = "first caracteristic",
                BMWCharacteristic2 = "second caracteristic"

            };


            var audi1 = new Audi
            {
                Color = "Green",
                Name = "audiA3",
                Enginepower = 234,
                EngineVolume = 3.2,
                designcost = 5000,
                AudiCaracteristic1 = "first caracteristic",
                AudiCaracteristic2 = "second caracteristic"

            };
            using (var contextC = new CarContext())
            {


                contextC.Add(audi1);
                contextC.Add(bmwx3);

                contextC.SaveChanges();
            }

    }

    }
}

