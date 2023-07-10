using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class StringReverseWithPalindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine("Reversed string: " + reversed);
            CheckPalindrome(input, reversed);
        }
        static string ReverseString(string input)
        {
            // Initialize an empty string to store the reversed string
            string reversed = "";
            // Iterate through the characters of the input string from the end to the beginning
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Append each character to the reversed string
                reversed += input[i];
            }
            return reversed;
        }

        static void CheckPalindrome(string Input, string Reversed)
        {
            //Compare Original and Reversed(Ignoring the case)  string are same or not
            if (Input.Equals(Reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("String is Palindrome "+ Input + Reversed);
            }
            else
            {
                Console.WriteLine("String is not Palindrome "+ Input+ Reversed);
            }
        }
    }
}
