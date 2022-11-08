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
            if (someInts.Contains(0))
            {
                Console.WriteLine("Talet 0 fanns med");
            }
            Console.WriteLine(someInts[0] + " " + someInts[1] + " " + someInts[tal]);
        }

        public static void RandomSevenNumber()
        {

        }

        public static void ListEx()
        {
            List<int> tal = new List<int>() { 1,2,3,8,7,6};
            if (tal.Contains(3))
            {
                Console.WriteLine("Yes");
            }
        }

    }
}
