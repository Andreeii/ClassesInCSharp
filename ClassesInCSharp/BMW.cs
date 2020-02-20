using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClassesInCSharp
{
     public class   BMW: Car,IEqualityComparer<BMW>
    {
        //nullable type field, deign cost can be null
        protected int? designcost;

        //parameterlessConstructor
        public BMW() { }

        //constructor with parameter
        public BMW(int id, string name ,int enginepower, double engineVolume, string color, int? designcost)
            : base(name,enginepower,engineVolume,color)
        {
            base.ID = id;
            this.designcost = designcost;
        }

        public bool Equals([AllowNull] BMW x, [AllowNull] BMW y)
        {
            return x.Enginepower == y.Enginepower && x.EngineVolume == y.EngineVolume;
        }

        public int GetHashCode([DisallowNull] BMW obj)
        {
            return obj.GetHashCode();
        }


        //first method for calculating price
        public  override double Price(Fuel f)
        {
            double price;
            if (designcost.HasValue)
            {
                if (f.fueltype == type.diesel)
                {
                    price = Enginepower * (int)EngineVolume * 2.3 + (int)designcost;
                }
                else
                {
                    price = Enginepower * (int)EngineVolume * 2.5 + (int)designcost;
                }

            }
            else if(f.fueltype ==type.diesel)
            {
                price = Enginepower * (int)EngineVolume * 2.3;
            }
            else
            {
                price = Enginepower * (int)EngineVolume * 2.5;
            }
            return price;
        }

        //second method for calculating price
        public  double Price()
        {
            if (designcost.HasValue)
            {
                return Enginepower * (int)EngineVolume * 1.1 + (int)designcost;
            }
            else
            {
                return Enginepower * (int)EngineVolume * 1.1;

            }
        }


        //to string method
        public override string ToString()
        {
            return "Brand: BMW  ," + "Name: "+this.Name;
        }
    }
}
