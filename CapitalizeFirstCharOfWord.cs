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

            foreach(string word in words)
            {
                char first = char.ToUpper(word[0]);//e.g. "T"
                string result = first+word.Substring(1);// e.g."T" + "his"
                Console.Write(result);
                Console.Write(" ");
            }
        }
    }
}
