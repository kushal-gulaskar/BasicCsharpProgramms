using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class RemoveDuplicatesWordFromArray
    {
        //static void Main(string[] args)
        //{
        //    string countries = "India,Japan,India,China";

        //    // Split the string into an array of words.
        //    string[] inputArray = countries.Split(',');

        //    string[] uniqueArray = inputArray.Distinct().ToArray();
        //    foreach(string s in uniqueArray)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        static void Main(string[] args)
        {
            string countries = "India,Japan,India,China";
            string[] words = countries.Split(',');

            /*To store unique elements: HashSet only stores unique elements. 
             This makes it a good choice for storing sets of data where duplicates are not allowed.*/
            HashSet<string> uniqueWords = new HashSet<string>(words);

            foreach (string country in uniqueWords)
            {
                Console.WriteLine(country);
            }
        }
    }
}
