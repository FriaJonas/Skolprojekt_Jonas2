using System.Diagnostics;
using System.Runtime;

namespace ConsoleApp
{
    class Program
    {
        static string name = "";
        static void Main(string[] args)
        {
            name = "Kung Bore";

            PrintName();
        }  

        static private void PrintName()
        {
            Console.WriteLine(name);
        }
        
    }
}
