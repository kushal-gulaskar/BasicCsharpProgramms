﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class NumberSwappingWithoutThirdVariable
    {
        public static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            // swap the values
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);
        }
    }
}
