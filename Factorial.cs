using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            int num = 5;
            int factorial = RecursiveFact(num);
            Console.WriteLine($"Factorial of {num} is {factorial} using Recursive function");
            factorial = NonRecursiveFact(num);
            Console.WriteLine($"Factorial of {num} is {factorial} using NonRecursive function");

        }
        static int RecursiveFact(int number)
        {
            // Base case: If the number is 0 or 1, return 1
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
                // Recursive case: Multiply the number with the factorial of (n-1)
                return number * RecursiveFact(number - 1);
        }
        static int NonRecursiveFact(int number)
        {
            // Initialize the factorial variable to 1
            int factorial = 1;

            // Multiply the numbers from 1 to n to calculate the factorial
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;   
            }

            // Return the calculated factorial
            return factorial;
        }
    }
}
