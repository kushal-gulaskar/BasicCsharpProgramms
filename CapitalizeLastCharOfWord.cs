using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    public class CapitalizeLastCharOfWord
    {
        public static void Main(string[] args)
        {
            string str = "This is a string";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                char lastChar = word[word.Length - 1];   //s
                lastChar = char.ToUpper(lastChar);      //S
                string wordNew = word.Substring(0, word.Length - 1) + lastChar; // Thi + S
                Console.WriteLine(wordNew);
            }
        }
    }
}
