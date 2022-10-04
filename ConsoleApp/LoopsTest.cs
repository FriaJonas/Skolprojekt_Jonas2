using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class LoopsTest
    {
        public static void ForExample()
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for(int i=0;i<10;i++)
            {
                int j = random.Next(1, 101);
                numbers[i] = j;
                Console.WriteLine("Tal " + i + " är" + j);
            }
            Console.WriteLine("Klar");
            ForEachExample(numbers);
        }

        static void ForEachExample(int[] num)
        {
            Array.Sort(num);
            foreach(int i in num)
            {
                Console.WriteLine("Talet är " + i);
            }
        }

        public static void WhileExample()
        {
            string password = "GodJul";
            bool youPass = false;

            Console.WriteLine("Ange lösenord");
            while(youPass==false)
            {
                string pass = Console.ReadLine();
                if(pass==password)
                {
                    youPass= true;
                }
                else
                {
                    Console.WriteLine("Fel lösen - försök igen!");
                }
            }
            Console.WriteLine("Grattis - du är inloggad!");
        }
    }
}
