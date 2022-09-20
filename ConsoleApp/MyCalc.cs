using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class MyCalc
    {
        public static void CalcAge()
        {
            Console.WriteLine("Hej, vad heter du?");
            string myName = Console.ReadLine();
            Console.WriteLine("Vilket år är du född?");
            string year = Console.ReadLine();

            int birthYear = int.Parse(year);
            int age = DateTime.Now.Year - birthYear;

            Console.WriteLine("Hej " + myName + ", du är " + age + " år gammal.....");

            CalcYearToPension(age);

        }

        public static void CalcYearToPension(int age)
        {
            int yearToPension = 65 - age;
            Console.WriteLine("Du har " + yearToPension + " år kvar till pension");
        }
    }
}
