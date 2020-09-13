using System;
using System.Diagnostics.Tracing;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    public class LargestNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter a counter: ");
            int counter = int.Parse(Console.ReadLine());
            // get first number and assign it to variable largest
            Console.WriteLine("Enter the number of units: ");
            for (int i = 0; i <= counter; i++ )
            {
                int num = int.Parse(Console.ReadLine());
            }

            // write your codes here
        }
    }
}
