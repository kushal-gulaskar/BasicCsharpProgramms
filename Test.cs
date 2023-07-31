using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    internal class Test
    {

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> even = new List<int> { };
            List<int> odd = new List<int> { };


            even = list.Where(li => li % 2 == 0).ToList();
            odd=list.Where(li=>li%2!=0).ToList();   
           
            foreach(int i in even)
                Console.Write(i);


            Console.WriteLine();
            foreach (int i in odd)
                Console.Write(i);
        }

        //public static void Main(string[] args)
        //{

        //    int[] nums = { 1, 2, 2, 3, 5 };
        //    int[] uniq = new int[nums.Length];
        //    int index = 0;


        //    for(int i=0;i<nums.Length; i++) 
        //    {
        //        bool dup = false;
        //        for(int j=0;j< index; j++)
        //        {
        //            if (nums[i] == nums[j])
        //            {
        //                dup = true;
        //                break;
        //            }
        //        }

        //        if(dup==false)
        //        {
        //            uniq[index] = nums[i];
        //            index++;
        //        }


        //    }
        //    for (int i = 0; i < index; i++)
        //    {
        //        Console.WriteLine(uniq[i]);
        //    }

        //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        //int[] even = new int[9];
        //int[] odd = new int[9];

        //for(int i=1;i<=nums.Length;i++)
        //{
        //    if(i%2==0)
        //    {
        //        even[i] = i;
        //    }
        //    else
        //    {
        //        odd[i] = i;
        //    }
        //}

        //foreach(int i in even)
        //{
        //    Console.Write(i);
        //}
        //Console.WriteLine();
        //foreach (int i in odd)
        //{
        //    Console.Write(i);
        //}

        //int input = 5;       
        //for (int i=1;i<=input;i++)
        //{
        //    for (int j=1;j<=input-i;j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=1;k<=2*i-1;k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}



        //List<int> list =new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //List<int> even = new List<int> { };
        //List<int> odd = new List<int> { };


        //for (int i = 0; i <= list.Count; i++) 
        //{
        //    if (i%2==0)
        //    {
        //        even.Add(i);
        //    }
        //    else
        //    {
        //        odd.Add(i);
        //    }
        //}
        //foreach(int i in even)
        //{
        //    Console.WriteLine(i);
        //}
        //foreach (int i in odd)
        //{
        //    Console.WriteLine(i);
        //}
        //even = list.Where(li => li % 2 == 0).ToList();
        //foreach (int li in even)
        //{
        //    Console.WriteLine(li);
        //}
        //odd = list.Where(lii => lii % 2 != 0).ToList();
        //foreach (int lii in odd)
        //{
        //    Console.WriteLine(lii);
        //}
    }
    }
