using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    internal class PyramidOfName
    {
        public static void Main(string[] args)
        {
            string input = "EPAM";
            string NamePyramid="";

            for(int i=0; i<= input.Length-1; i++)
            {
                NamePyramid = NamePyramid + input[i];
                Console.WriteLine(NamePyramid);
            }
        }
    }
}
