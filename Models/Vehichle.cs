using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_downcasting.Models
{
    public abstract class Vehichle
    {
        public Vehichle(int price)
        {
            Price = price;
        }
        public int Price { get; set; }
        public abstract void Drive();

        public static bool operator >(Vehichle car, Vehichle car1)
        {
            return car.Price > car1.Price;
        }
        public static bool operator <(Vehichle car, Vehichle car1)
        {
            return car.Price < car1.Price;
        }
    }
}
