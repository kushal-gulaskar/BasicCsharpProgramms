using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            int count = 5;

            Console.WriteLine("Fibonacci sequence:");

            // Generate and display the Fibonacci sequence
            for (int i = 0; i < count; i++)
            {
                int fibonacci = Fibo(i);
                Console.WriteLine(fibonacci);
            }
        }
        static int Fibo(int n)
        {
            // Base cases: If n is 0 or 1, return n
            if (n == 0 || n == 1)
            {
                return n;
            }

            // Initialize variables for the two previous Fibonacci numbers
            int prev1 = 0;
            int prev2 = 1;
            int fibonacci = 0;

            // Generate the Fibonacci number for n by summing the two previous numbers
            for (int i = 2; i <= n; i++)
            {
                fibonacci = prev1 + prev2;
                prev1 = prev2;
                prev2 = fibonacci;
            }

            // Return the generated Fibonacci number
            return fibonacci;
        }
    }
}
