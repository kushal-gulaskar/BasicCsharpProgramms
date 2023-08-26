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
            int factorial = 1;

            // Multiply the numbers from 1 to n to calculate the factorial
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            // Return the calculated factorial
            Console.WriteLine(factorial);
        }
    }
}
