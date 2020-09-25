using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {
            Console.Error.Write("Enter the last number of Fibonacci Sequence of numbers: ");
            int end = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 1;
            Console.Error.WriteLine(first);
            Console.Error.WriteLine(second);

            while (first + second <= end)
            {
                int third = first + second;
                first = second;
                second = third;
                Console.Error.WriteLine(third);
            }


        }
    }
}
