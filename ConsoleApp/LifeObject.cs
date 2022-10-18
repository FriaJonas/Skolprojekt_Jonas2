using ConsoleApp.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class LifeObject
    {
        public LifeObject()
        {
            Car c = new Car()
            {
                Color = "Blue",
                Name = "Ford",
                Price = 100000
            };
            Console.WriteLine(c.Color);
            ChangeColor(c);
            Console.WriteLine(c.Color);
        }

        public void ChangeColor(Car c2)
        {
            Console.WriteLine(c2.Color);
            c2.Color = "Black";
            Console.WriteLine(c2.Color);
        }
    }
}
