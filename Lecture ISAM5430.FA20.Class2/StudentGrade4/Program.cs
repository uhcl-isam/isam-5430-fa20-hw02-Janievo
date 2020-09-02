using System;
using System.Threading.Tasks.Sources;

namespace StudentGrade4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total = 0m;

            int i = 0;
            decimal score = 0;
            //enter a list of scores until one of the score is negative.
            while (score >= 0) //enter as many score as you want 
            {
                i++;
                Console.WriteLine($"Enter the score for student #{i}.");
                score = decimal.Parse(Console.ReadLine());
                if (score >= 0)
                {
                    if (score > 100)
                    {
                        Console.Error.WriteLine("Invalid score, please enter again");
                        i--;
                    }
                    else
                    {
                        total += score;
                    }
                }
            }
            if (i > 0)
            {
                decimal average = total / (i - 1);
                Console.WriteLine($"The average is {average:N2}.");
            }
            else
            {
                Console.WriteLine("You have not enter any score");
            }
        }
    }
}
