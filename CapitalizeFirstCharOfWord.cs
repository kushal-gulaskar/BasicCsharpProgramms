using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    internal class CapitalizeFirstCharOfWord
    {
        static void Main(string[] args)
        {
            string testString = "this is kushal";

            // Split the string into words.
            string[] words = testString.Split(' ');

            // Capitalize the first letter of each word.
            for (int i = 0; i < words.Length; i++)
            {
                char one = char.ToUpper(words[i][0]);   //e.g. "T"
                string two= words[i].Substring(1);     // e.g."his"
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1); 
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
                Console.Write(" ");
            }
            // Concatenate the capitalized words back into a string.
            string capitalizedString = string.Join(" ", words);

            //// Print the resulting string.
            //Console.WriteLine(capitalizedString);
        }
    }
}
