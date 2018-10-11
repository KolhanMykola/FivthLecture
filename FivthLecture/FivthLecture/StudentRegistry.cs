using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivthLecture
{
    public static class StudentRegistry
    {
        static List<Student> info = new List<Student>();

        static StudentRegistry()
        {
                       
        }

        public static void AddStudent(Student a)
        {
            info.Add(a);
        }

        public static void RemoveStudent(Student a)
        {
            info.Remove(a);
        }

        public static string GetAllInfo()
        {
            string output = null;
            int counter = 1;
            foreach (var student in info)
            {
                output +=  counter.ToString() + "." + student.GetStudentInfo();
                counter++;
            }

            return output;
        }
    }
}
