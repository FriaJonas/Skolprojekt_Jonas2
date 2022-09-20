using System.Diagnostics;
using System.Runtime;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintName();
            //InputName();

            Array.Start();
        }  

        static private void PrintName()
        {
            Console.WriteLine("Jonas");
            
        }
        static void InputName()
        {
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
        
    }
}
