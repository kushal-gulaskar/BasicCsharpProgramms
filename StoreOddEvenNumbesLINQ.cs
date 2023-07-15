using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    internal class StoreOddEvenNumbesLINQ
    {
        static void Main(string[] args)
        {
            // Create a list of numbers from 1 to 100
            var numbers = Enumerable.Range(1, 100);

            // Store even numbers in a list
            var evenNumbers = numbers.Where(x => x % 2 == 0);

            // Store odd numbers in a list
            var oddNumbers = numbers.Where(x => x % 2 != 0);

            // Print the even numbers
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number);
            }

            // Print the odd numbers
            Console.WriteLine("Odd numbers:");
            foreach (var number in oddNumbers)
            {
                Console.Write(number);
            }
        }
    }
}
