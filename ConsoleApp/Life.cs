using ConsoleApp.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Life
    {
        int tal = 20;


        public Life()
        {
            int tal = 20;
            Console.WriteLine(tal);

            ChangeNumber(tal);

            Console.WriteLine(tal);
        }

        public void ChangeNumber(int tal2)
        {
            Console.WriteLine(tal2);
            tal2 = 76;
            Console.WriteLine(tal2);
        }
    }
}
