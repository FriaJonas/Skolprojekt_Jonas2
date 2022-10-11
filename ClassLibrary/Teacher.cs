using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher:User
    {
        public string Title { get; set; }
        public int Salary { get; set; }
        public bool IsMentor { get; set; } // Ja/Nej om läraren är mentor

    }
}
