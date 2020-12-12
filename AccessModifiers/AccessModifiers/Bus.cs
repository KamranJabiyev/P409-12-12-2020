using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brand,string model,double price,int pCount)
        {
            Brand = brand;
            Model = model;
            Price = price;
            PassengerCount = pCount;
        }

        public override string CarDetail()
        {
            Test();
            return $"{Brand} {Model} {Price} {PassengerCount}";
        }
    }
}
