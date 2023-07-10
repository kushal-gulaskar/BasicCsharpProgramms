using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class Pyramid
    {
        public static void Main(string[] args)
        {
            int rows = 5;
            Console.WriteLine("Number of rows: " + rows);

            // Call the PyramidPattern function to generate the pyramid
            PyramidPattern(rows);
        }

        static void PyramidPattern(int rows)
        {
            // Iterate through each row
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces for each row to align the pyramid
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for each row to create the pyramid shape
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line after each row
                Console.WriteLine();
            }
        }
    }
}
