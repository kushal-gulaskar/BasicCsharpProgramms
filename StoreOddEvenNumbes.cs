using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    internal class StoreOddEvenNumbes
    {
        static void Main(string[] args)
        {
            // Create two arrays to store the even and odd numbers.
            int[] evenNumbers = new int[100];
            int[] oddNumbers = new int[100];

            // Iterate through the numbers from 1 to 100.
            for (int i = 1; i < 100; i++)
            {
                // Check if the number is even.
                if (i % 2 == 0)
                {
                    // Add the number to the even numbers array.
                    evenNumbers[i] = i;
                }
                else
                {
                    // Add the number to the odd numbers array.
                    oddNumbers[i] = i;
                }
            }

            // Print the even numbers.
            Console.WriteLine("Even numbers:");
            foreach(int nums in evenNumbers)
            {
                Console.Write(nums);
            }

            Console.WriteLine("Odd numbers:");
            foreach (int nums in oddNumbers)
            {
                Console.Write(nums);
            }
        }
    }
}
