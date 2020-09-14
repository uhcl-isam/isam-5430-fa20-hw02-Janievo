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
            int largest;
            int largest2 = 0;

            Console.Error.Write("Enter the counter: ");
            int counter = int.Parse(Console.ReadLine());

            //get the first number and assign it to variable largest
            Console.Error.Write("Enter the number of units: ");
            largest = Convert.ToInt32(Console.ReadLine());
            //write your code here to set the first number as the max
            //if there is only 1 number entered, then set both max and max 2 to be that number;
            if (counter ==1 && counter !=0)
            {
                largest2 = largest;               
            }
            else if (counter >1)
            {
                for (int i =2; i <= counter; i++)
                {
                    Console.Error.Write("Enter the number of units: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    //if number > max, then set max2 = max and max = number 
                    if (num > largest)
                    {
                        largest2 = largest;
                        largest = num;
                    }
                    //otherwise, if number <max
                    else
                    {
                        largest2 = num;
                    }
                }
            }
            Console.WriteLine($"The largest number is {largest}");
            Console.WriteLine($"The second largest number is {largest2}");
        }
    }
}
