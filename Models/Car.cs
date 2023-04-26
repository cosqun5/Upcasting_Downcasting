using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_downcasting.Models
{
    public class Car : Vehichle
    {
        public Car(int price) : base(price)
        {

        }

        public override void Drive()
        {
            Console.WriteLine("This is car");
        }
        //public static bool operator >(Car car, Car car1)
        //{
        //    return car.Price > car1.Price;
        //}
        //public static bool operator <(Car car, Car car1)
        //{
        //    return car.Price < car1.Price;
        //}
    }
}
