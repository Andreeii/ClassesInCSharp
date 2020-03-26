using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassesInCSharp
{
    public abstract class Engine
    {
        public int EngineId { get; set; }
        public double EngineVolume { get; set; }

        [Required]
        public string BrandName { get; set; }
        public Fuel FuelType { get; set; }

        public int? designcost;

 
    }
}
