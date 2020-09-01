using System;
using static System.Console;

namespace StudentGrade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter student score.
            //print the letter grade from that score.
            Write("Enter a score: ");
            string gradeInput = ReadLine();
            int grade = Convert.ToInt32(gradeInput);
            if (grade > 100 || grade < 0)
            // !(grade >= 0 && grade <= 100)  D'Morgan 's Law
            {
                WriteLine("Invaid Grade");
            }
            else
            {
                if (grade >= 90)
                {
                    WriteLine($"The letter of {grade} is A");
                }
                else if (grade >= 80)
                {
                    WriteLine($"The letter of {grade} is B");
                }
                else if (grade >= 70)
                {
                    WriteLine($"The letter of {grade} is C");
                }
                else if (grade >= 60) // && grade 70
                {
                    WriteLine($"The letter of {grade} is D");
                }
                else
                {
                    WriteLine($"The letter of {grade} is F");
                }

            }
        }
    }
}