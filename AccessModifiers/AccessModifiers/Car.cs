using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        private int _speed;
        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand,string model,double price,int speed)
        {
            Brand = brand;
            Model = model;
            Price = price;
            _speed = speed;
        }
        //encapsulation
        public int Speed {
            get
            {
                return _speed;
            }
            set 
            {
                if (value < 400)
                {
                    _speed = value;
                    return;
                }
                Console.WriteLine("Suret 400-den yuxari ola bilmez!!!");
            }
        }

        //public int GetSpeed()
        //{
        //    return _speed;
        //}

        //public void SetSpeed(int speed)
        //{
        //    if (speed < 400)
        //    {
        //        _speed = speed;
        //        return;
        //    }
        //    Console.WriteLine("Suret 400-den yuxari ola bilmez!!!");
        //}

        public override string ToString()
        {
            return $"{Brand} {Model} {_speed}";
        }

        public virtual string CarDetail()
        {
            return $"{Brand} {Model} {Price}";
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
