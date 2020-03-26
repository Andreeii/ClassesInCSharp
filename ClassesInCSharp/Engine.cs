using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    public abstract class Engine
    {
        public int EngineId { get; set; }
        public int Enginepower { get; set; }
        public double EngineVolume { get; set; }
        public string Color { get; set; }
        public string BrandName { get; set; }
        public Fuel FuelType { get; set; }

        public int? designcost;

 
    }
}
