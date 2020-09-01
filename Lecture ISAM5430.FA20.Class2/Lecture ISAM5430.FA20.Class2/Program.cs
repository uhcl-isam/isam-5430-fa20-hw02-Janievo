using System;
using System.Runtime.Serialization;

namespace Lecture_ISAM5430.FA20.Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter a student's grade
            string gradeInput = Console.ReadLine();
            int grade = Convert.ToInt32(gradeInput);

            //display pass if pass
            if (grade >= 70)
            {
                Console.WriteLine("Passed");
            }
            //display fail if not pass
            else //same as if (!(grade >= 70)
            {
                Console.WriteLine("Failed");
            }
            // Cach 2:
            string message = grade >= 70 ? "Passed" : "Failed";
            Console.WriteLine(message);
        }
    }
}
