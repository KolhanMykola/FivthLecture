using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivthLecture
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string dateOfAdmission;
        private StudentAddress studentAddress;

        public Student()
        {
        }

        public Student(string firstName, string lastName, string dateOfAdmission, StudentAddress studentAddress)
        {
            CheckValid.IsString(ref firstName);
            this.firstName = firstName;
            CheckValid.IsString(ref lastName);
            this.lastName = lastName;
            CheckValid.IsDate(ref dateOfAdmission);
            this.dateOfAdmission = dateOfAdmission;
            this.studentAddress = studentAddress;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string DateOfAdmission
        {
            get { return dateOfAdmission; }
            set { dateOfAdmission = value; }
        }

        public StudentAddress StudentAddress
        {
            get { return studentAddress; }
            set { studentAddress = value; }
        }

        public string GetStudentInfo()
        {
            return $"Student`s info: {FirstName}\t{LastName}\t{DateOfAdmission}\t{StudentAddress}\n";
        }
    }
}