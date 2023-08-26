using System;
using System.Text;

namespace CSharpProgramms
{
    class StringReverse
    {
        public static void Main(string[] args)
        {
            string input = "Name";
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed = reversed + input[i];
            }
            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}