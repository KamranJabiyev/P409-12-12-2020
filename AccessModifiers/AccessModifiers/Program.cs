using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Access Modifiers

            #region Public - field,method,property - class
            //Car car = new Car("BMW", "X6", 20000);
            //car.Brand = "Mercedes";
            //car.Test();
            //Console.WriteLine(car.Brand);
            #endregion

            #region Private - all class members(method,field,property)
            Car car = new Car("BMW", "X6", 20000, 300);
            //car.SetSpeed(450);
            //Console.WriteLine(car.GetSpeed());
            car.Speed = 450;
            Console.WriteLine(car.Speed);
            #endregion

            #endregion
        }
    }
}
