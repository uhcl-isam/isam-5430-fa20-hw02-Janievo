using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            int count = 0;
            Console.Error.Write("Enter an account number: ");
            int acct_num = int.Parse(Console.ReadLine());

            while (true)
            {
                if( acct_num <0)
                {
                    break;
                }
                else
                {
                    Console.Error.Write("Enter beginning balance: ");
                    int begin_bal = int.Parse(Console.ReadLine());
                    Console.Error.Write("Enter total items Charge: ");
                    int charges = int.Parse(Console.ReadLine());
                    Console.Error.Write("Enter total credit: ");
                    int credits = int.Parse(Console.ReadLine());
                    Console.Error.Write("Enter credit limit: ");
                    int credit_limit = int.Parse(Console.ReadLine());
                    
                    if (begin_bal <0 || charges <0 || credits <0 || credit_limit <0)
                    {
                        break;
                    }
                    else
                    {
                        int new_bal = begin_bal + charges - credits;
                        Console.Error.Write($"New balance: {new_bal}");
                        int remaining_bal = credit_limit - new_bal;
                        Console.Error.Write($"Remaining balance: {remaining_bal}");

                        if (credit_limit < new_bal)
                        {
                            Console.Error.WriteLine("Credit Limit Exceeded");
                        }
                    }
                    count++;
                    Console.Error.Write("Enter an account number: ");
                    acct_num = int.Parse(Console.ReadLine());
                }
            }
        }
    }
} 
