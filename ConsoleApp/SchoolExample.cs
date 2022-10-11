
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SchoolExample
    {
        public void Start()
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Jonas";
            teacher.LastName = "Nilsson";
            teacher.IsMentor = false;
            teacher.Email = "jonas.nilsson@laroverken.se";

            Student student = new Student();
            student.FirstName = "Kalle";
            student.LastName = "Kula";
            student.BirthYear = 2005;
            student.ClassCode = "EDAT222";

        }
        public void ListStudentExample()
        {
            //Vi definierar att vi vill ha en lista med studenter
            List<Student> StudentList = new List<Student>();
            //Skapar första studenten
            Student student = new Student();
            student.FirstName = "Kalle";
            student.LastName = "Kula";
            student.BirthYear = 2005;
            student.ClassCode = "EDAT222";
            //Vi lägger till student till listan
            StudentList.Add(student);

            //Skapar student 2
            Student student2 = new Student();
            student2.FirstName = "Stina";
            student2.LastName = "Långstrump";
            student2.BirthYear = 2006;
            student2.ClassCode = "Tek21";
            StudentList.Add(student2);

            foreach(Student s in StudentList)
            {
                s.printDisplayName();
                s.PrintStudentInfo();
                Console.WriteLine("--------------------");
            }
        }

    }
}
