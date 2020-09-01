using System;
using static System.Console;

namespace StudentGrade2
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter student score.
            //print the letter grade from that score.
            WriteLine("Enter a score");
            string gradeInput = ReadLine();
            int grade = Convert.ToInt32(gradeInput);
            int firstDigit = grade / 10;
            switch(firstDigit)
            {
                case 10:
                case 9:
                    WriteLine("A");
                    break;
                case 8:
                    WriteLine("B");
                    break;
                case 7:
                    WriteLine("C");
                    break;
                default:
                    WriteLine("F");
                    break;
            }
        }
    }
}
