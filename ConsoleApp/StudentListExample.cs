using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class StudentListExample
    {
        public void ArrayTest()
        {
            // Här ska vi skapa en lista med personuppgifter utan objekorrientering 
            // Eftersom vi ska ha en lista så ska vi här använda array

            Console.WriteLine("Hur många namn ska du mata in?");
            int nr=int.Parse(Console.ReadLine());

            string[] firstName = new string[nr];
            string[] lastName = new string[nr];
            string[] phone = new string[nr];
            string[] email = new string[nr];
            int[] birthYear = new int[nr];

            for(int i = 0; i < nr; i++)
            {
                Console.WriteLine("Förnamn:");
                firstName[i] = Console.ReadLine();
                Console.WriteLine("Efternamn");
                lastName[i] = Console.ReadLine();
                Console.WriteLine("Telefon: ");
                phone[i] = Console.ReadLine();
                Console.WriteLine("Epost; ");
                email[i] = Console.ReadLine();
                Console.WriteLine("Födelseår: ");
                birthYear[i] = int.Parse(Console.ReadLine());
                PrintStudents(firstName, lastName, phone, email, birthYear);
            }

        }
        public void PrintStudents(string[] firstNames, string[] lastNames,string[] phonNumbers, string[] emails, int[] birthYears)
        {
            if(firstNames.Length > 0)
            {
                for(int i=0; i<firstNames.Length; i++){
                    Console.WriteLine(firstNames[i]+", " + lastNames[i]+", " + phonNumbers[i]+", " + emails[i]+", "+birthYears[i]);
                }
            }
            
        }

        public void ObjectTest()
        {
            //Här ska vi istället skapa en lista där vi använder en klass istället
            List<StudentInfo> sInfo = new List<StudentInfo>();
            AddStudent(sInfo);
            PrintInfo(sInfo);

        }
        private void AddStudent(List<StudentInfo> sInfo)
        {
            StudentInfo si = new StudentInfo();
            Console.WriteLine("Förnamn:");

            si.firstName = Console.ReadLine();
            Console.WriteLine("Efternamn:");
            si.lastName = Console.ReadLine();
            Console.WriteLine("Epost:");
            si.email = Console.ReadLine();
            Console.WriteLine("Telefon:");
            si.phone = Console.ReadLine();
            Console.WriteLine("Födelseår:");
            si.birthYear = int.Parse(Console.ReadLine());
            sInfo.Add(si);
            Console.WriteLine("Vill du mata in fler j/n");
            string answer = Console.ReadLine();
            if (answer == "j")
            {
                AddStudent(sInfo);
            }
            
        }

        private void PrintInfo(List<StudentInfo> sInfo)
        {
            foreach(StudentInfo si in sInfo)
            {
                Console.WriteLine(si.firstName + " " + si.lastName+ " "+si.phone+" "+si.email+" "+si.birthYear);
            }
        }
    }

    public class StudentInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int birthYear { get; set; }

    }

}
