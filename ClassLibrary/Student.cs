using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student:User
    {
        public int BirthYear { get; set; } 
        public string ClassCode { get; set; }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Födelseår: {BirthYear}, Klass: {ClassCode}");
        }
    }
}
