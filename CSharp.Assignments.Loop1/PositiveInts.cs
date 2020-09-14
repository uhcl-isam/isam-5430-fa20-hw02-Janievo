using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
            Console.Error.Write("Enter the value of n");
            // write your codes here.
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            // if you need a repetition, use while
            // if you need once or none, use if statement 
            while(i <=n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
