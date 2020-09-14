using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
            Console.Error.Write("Enter the counter:");
            int counter = Convert.ToInt32(Console.ReadLine());
            int count  = 0;
            int num1 = -1;

            for (int i = 1; i <= counter; i ++)         
            {
                Console.Error.WriteLine("Enter the an interger or a CTRL-Z to end: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num1 == num)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
