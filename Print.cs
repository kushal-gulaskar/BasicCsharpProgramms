/***********************************************************************/
//1. Reverse Each word from given string
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Text;

internal class ReverseEachWordFromStringNew
{
    public static void Main(string[] args)
    {
        string originalString = "This Is Kushal";

        string[] Splitstring = originalString.Split(' ');

        string reverseWordString = string.Join(" ", Splitstring
        .Select(x => new String(x.Reverse().ToArray())));

        Console.WriteLine(reverseWordString);
    }
}
//O/P: sihT sI lahsuK
/***********************************************************************/

//2. Capitalize first char of Each word from given string
internal class CapitalizeFirstCharOfWord
{
    static void Main(string[] args)
    {
        string testString = "this is kushal";

        // Split the string into words.
        string[] words = testString.Split(' ');

        foreach (string word in words)
        {
            char firstChar = char.ToUpper(word[0]);//e.g. "T"
            string wordNew = firstChar + word.Substring(1);// e.g."T" + "his"
            Console.Write(wordNew);
            Console.Write(" ");
        }
    }
}
//O/P: This Is Kushal
/***********************************************************************/





//3. Capitalize last char of Each word from given string
public class CapitalizeLastCharOfWord
{
    public static void Main(string[] args)
    {
        string str = "This is a string";

        string[] words = str.Split(' ');

        foreach (string word in words)
        {
            char lastChar = char.ToUpper(word[word.Length - 1]); //S
            string wordNew = word.Substring(0, word.Length - 1) + lastChar; // Thi + S
            Console.Write(wordNew);
            Console.Write(" ");
        }
    }
}
//O/P: ThiS iS A strinG
/***********************************************************************/

//5. Store Odd and Even numbers in seprate array
internal class StoreOddEvenNumbes
{
    static void Main(string[] args)
    {
        // Create two arrays to store the even and odd numbers.
        int[] evenNumbers = new int[100];
        int[] oddNumbers = new int[100];

        // Iterate through the numbers from 1 to 100.
        for (int i = 1; i < 100; i++)
        {
            // Check if the number is even.
            if (i % 2 == 0)
            {
                // Add the number to the even numbers array.
                evenNumbers[i] = i;
            }
            else
            {
                // Add the number to the odd numbers array.
                oddNumbers[i] = i;
            }
        }

        Console.WriteLine("Even numbers:");
        foreach (int nums in evenNumbers)
        {
            Console.Write(nums);
        }

        Console.WriteLine("Odd numbers:");
        foreach (int nums in oddNumbers)
        {
            Console.Write(nums);
        }
    }
}
/*O/P: Even numbers:
0020406080100120140160180200220240260280300320340360380400420440460480500520540560580600620640660680700720740760780800820840860880900920940960980
Odd numbers:
0103050709011013015017019021023025027029031033035037039041043045047049051053055057059061063065067069071073075077079081083085087089091093095097099
/***********************************************************************/

//6. Store Odd and Even numbers in seprate array using LINQ
internal class StoreOddEvenNumbesLINQ
{
    static void Main(string[] args)
    {
        // Create a list of numbers from 1 to 100
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = nums.Where(x => x % 2 == 0);
        
        var oddNumbers = nums.Where(x => x % 2 != 0);

        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.Write(number);
        }

        Console.WriteLine("Odd numbers:");
        foreach (var number in oddNumbers)
        {
            Console.Write(number);
        }
    }
}
/*O/P: Even numbers:
       246810
       Odd numbers:
       13579
/***********************************************************************/

//7. Remove Duplicates values from Array
class RemoveDuplicatesFromarray
{
    public static void Main(string[] args)
    {
        // Create a static array with duplicate values
        int[] nums = { 1, 2, 3, 1, 2, 3, 4, 5 };

        // Create a new array to store the distinct values
        int[] unique = new int[nums.Length];
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the current element is already in the new array
            bool isDup = false;
            for (int j = 0; j < index; j++)
            {
                if (nums[i] == nums[j])
                {
                    isDup = true;
                    break;
                }
            }

            // If the current element is not a duplicate, add it to the new array
            if (isDup == false)
            {
                unique[index] = nums[i];
                index++;
            }
        }

        foreach (int num in unique)
        {
            Console.Write(num);
        }
    }
}
//O/P: 12345000
/***********************************************************************/






//8. Factorial
class Factorial
{
    public static void Main(string[] args)
    {
        int num = 5;
        int factorial = 1;

        // Multiply the numbers from 1 to n to calculate the factorial
        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        // Return the calculated factorial
        Console.WriteLine(factorial);
    }
}
//O/P: 120
/***********************************************************************/

//9. Reverse Given String
internal class StringReverse
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
//O/P: Reversed string: emaN
/***********************************************************************/











//10. Pyramid Pattern
class Pyramid
{
    public static void Main(string[] args)
    {
        int rows = 5;
        Console.WriteLine("Number of rows: " + rows);

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces for each row to align the pyramid
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks for each row to create the pyramid shape
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            // Move to the next line after each row
            Console.WriteLine();
        }
    }
}
/*O/P:
Number of rows: 5
    *
   ***
  *****
 *******
*********
/***********************************************************************/


//11. Pyramid pattern Name
internal class PyramidOfName
{
    public static void Main(string[] args)
    {
        string input = "EPAM";
        string NamePyramid = "";

        for (int i = 0; i <= input.Length - 1; i++)
        {
            NamePyramid = NamePyramid + input[i];
            Console.WriteLine(NamePyramid);
        }
    }
}
/*O/P:
E
EP
EPA
EPAM
/***********************************************************************/

//12. Number Swapping without using third variable
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
/*O/P:
After swapping:
First number: 20
Second number: 10
/***********************************************************************/