using System;

namespace StudentGrade3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total = 0m;

            int i = 0;
            while (i<10) //enter limit to 10 scores
            {
                i++;
                Console.WriteLine($"Enter the score for student #{i}.");
                decimal score = decimal.Parse(Console.ReadLine());
                if (score <0 || score >100)
                {
                    Console.Error.WriteLine("Invalid score, please enter again");
                    i--;
                }
                else
                {
                    total += score;
                }
            }
            decimal average = total / 10;
            Console.WriteLine($"The average is {average}.");
        }
    }
}
