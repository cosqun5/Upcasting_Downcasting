using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_downcasting.Models
{
    public class Bus : Vehichle
    {
        public Bus(int price) : base(price)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("This is bus");
        }
    }
}
