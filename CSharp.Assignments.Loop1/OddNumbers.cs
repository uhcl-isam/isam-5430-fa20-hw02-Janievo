using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {

            // Codes to enter start
            Console.Error.WriteLine("Enter the starting number");
            int num1 = int.Parse(Console.ReadLine());
            // Codes to enter end.
            Console.Error.WriteLine("Enter the ending number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The odd integers between {num1} and {num2}: ");
            for (i = num1; i <= num2; i++)
            {
                if (i > 0)
                {
                    if ( i %2 !=0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
