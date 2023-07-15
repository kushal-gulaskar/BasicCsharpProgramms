using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    class TestRemoveDuplicatesFromarray
    {
        public static void Main(string[] args)
        {
            // Create a static array with duplicate values
            int[] nums = { 1, 2, 3, 1, 2, 3, 4, 5 };

            // Create a new array to store the distinct values
            int[] unique=new int[nums.Length];
            int index = 0;

            // Iterate through the original array
            for (int i=0; i<nums.Length; i++)
            {
                // Check if the current element is already in the new array
                bool isDup =false;
                for(int j=0; j< index;j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isDup = true;
                        break;
                    }
                }

                // If the current element is not a duplicate, add it to the new array
                if (isDup== false)
                {
                    unique[index] = nums[i];
                    index++;
                }
            }

            // Print the new array without duplicates
            for (int i=0;i<unique.Length;i++)
            {
                Console.Write(unique[i]);
            }
        }
    }
}
