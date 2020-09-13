using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunch of integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here
            Console.Error.Write("Enter a counter: ");
            int counter = int.Parse(Console.ReadLine());

            int count = 0;
            Console.Error.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i =0; i <= counter; i++)
            {
                if (i == num)
                {
                    count =+ 1;
                }
                count =+ 0;
            }
            Console.WriteLine(count);
        }
    }
}
