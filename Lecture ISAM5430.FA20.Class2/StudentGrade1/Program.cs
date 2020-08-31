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
            WriteLine("Enter a score");
            string gradeInput = ReadLine();
            int grade = Convert.ToInt32(gradeInput);
            if (grade > 100 || grade <0) //!(grade >=0 && grade <=100)// D'Morgan's Law
            {

            }


        }
    }
}
