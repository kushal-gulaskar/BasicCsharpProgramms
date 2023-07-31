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
            List<int> nums= new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Store even numbers in a list
            var evenNumbers = nums.Where(x => x % 2 == 0);

            // Store odd numbers in a list
            var oddNumbers = nums.Where(x => x % 2 != 0);

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
