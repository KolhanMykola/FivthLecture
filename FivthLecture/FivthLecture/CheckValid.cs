using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivthLecture
{
    class CheckValid
    {
        static string incorrectDate = "Incorrect date";
        static string incorrect = "Incorrect";

        public static void IsDate(ref string input)
        {
            try
            {
                DateTime.Parse(input);
            }
            catch (Exception)
            {
                input = incorrectDate;
            }           
        }

        public static void IsString(ref string input)
        {
            if(string.IsNullOrWhiteSpace(input) || input.Any(char.IsDigit))              
                input = incorrect;            
        }

        public static void IsAdress(ref string input)
        {
            if(string.IsNullOrWhiteSpace(input))
                input = incorrect;
        }
    }
}
