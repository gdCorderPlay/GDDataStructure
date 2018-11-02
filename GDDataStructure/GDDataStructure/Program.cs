using System;
using System.Collections.Generic;
using System.Text;

namespace GDDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            GDListArray<int> nums = new GDListArray<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Insert(5, 2);
            Console.WriteLine(nums.Count);
            Console.WriteLine(nums[2]);
           
        }
    }
}
