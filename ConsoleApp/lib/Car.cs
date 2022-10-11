using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.lib
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Car(string name, string color, int price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name +" "+ Color +" "+Price);
        }

    }
}
