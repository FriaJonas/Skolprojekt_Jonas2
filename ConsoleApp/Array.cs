using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ArrayEx
    {
        public static void Start()
        {
            Random random = new Random();
            int tal = 2;

            int NyttTal = random.Next(0, 7);

            int[] someInts = new int[3];
            someInts[0]= random.Next(1,101);
            someInts[1] = random.Next(1000, 10001);
            someInts[2] = random.Next(1, 11);
            Console.WriteLine(someInts[0] + " " + someInts[1] + " " + someInts[tal]);
        }

        public static void RandomSevenNumber()
        {

        }

    }
}
