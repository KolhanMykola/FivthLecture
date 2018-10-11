using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivthLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 data(firstName, lastName, dateOfAdmission, Country, City, Adress) of students:");            
            StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
            StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
            StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
            Console.WriteLine(StudentRegistry.GetAllInfo());
            Console.ReadLine();
        }
    }
}
