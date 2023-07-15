using System;
using System.Text;

class StringReverse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversed);
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
}