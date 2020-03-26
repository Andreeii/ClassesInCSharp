using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassesInCSharp
{
   public abstract class Car
    {
        public int CarId { get; set; }

        public Engine Engine { get; set; }

        [Required]
        public string Colour { get; set; }
        public int Price { get; set; }

        public string Category { get; set; }
    }
}
