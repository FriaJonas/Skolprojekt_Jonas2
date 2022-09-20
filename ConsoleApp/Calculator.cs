using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Calculator
    {
        static int NyttTal=0;
        public static void ShowSum(int tal1, int tal2)
        {
            NyttTal++;

            int sum = tal1 + tal2 +20;
            Console.WriteLine("Summa:" + sum);
        }

        public static void Uppgift1()
        {
           
            Console.WriteLine("Hej, vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Vilket år är du född?");
            string birthYear = Console.ReadLine();
            int year = int.Parse(birthYear);
            int age = DateTime.Now.Year - year;

            Console.WriteLine("Hej " + name + ", du är " + age + " år gammal");

            int yearToPension = 65 - age;

            if (yearToPension > 0 )
            {
                Console.WriteLine("Du har " + yearToPension + " år till pension");
            }
            else if (yearToPension == 0)
            {
                Console.WriteLine("Du borde gå i pension nu!!!!");
            }
            else
            {
                Console.WriteLine("Du gick i pension för " + yearToPension + "år sedan");
            }
        }
    }
}
