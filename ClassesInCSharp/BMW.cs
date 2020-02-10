using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
     public class   BMW:Car
    {
        public Fuel fuel ;
        int i;
        public BMW() { }
        protected int designcost;

        public BMW(int enginepower, double engineVolume, string color, int designcost)
            : base(enginepower,engineVolume,color)
        {
           
            this.designcost = designcost;
        }

        public  override double Price(Fuel f)
        {
            double price;
            if (f.fueltype == type.diesel)
            {
                price = enginepower * (int)engineVolume *1.3 + designcost;
            }
            else
            {
                price = enginepower * (int)engineVolume *1.5 + designcost;
            }
            return price;
        }
            
    }
}
