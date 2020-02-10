using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
  public  struct Fuel
    {

        public type fueltype;
        public int price { get; set; }
        public Fuel(type t, int price)
        {
            this.fueltype = t;
            this.price = price;
        }
    }
    public enum type
    {

        diesel,
        benzin,
        gaz
    }
}
