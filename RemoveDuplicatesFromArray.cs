using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    internal class RemoveDuplicatesFromArray
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 2, 3, 3, 4, 5, 6 };
            int[] newArray = new int[array.Length];

            int newArrayIndex = 0;

          //  Console.WriteLine(num[]);

            for (int i = 0; i < array.Length; i++)
            {
                bool isDupli = false;
                for (int j = 0; j < newArrayIndex; j++)
                {
                    if (array[i] == newArray[j])
                    {
                        isDupli = true;
                        break;
                    }
                }
                if (!isDupli)
                {
                    newArray[newArrayIndex] = array[i];
                    newArrayIndex++;
                }
            }

            for(int i=0; i < newArrayIndex; i++)
            {
                Console.WriteLine(newArray[i]); 
            }
        }
       
    }
}
