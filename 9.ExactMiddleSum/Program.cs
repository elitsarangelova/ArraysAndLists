﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExactMiddleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = MiddleSum(nums);
            Console.WriteLine(string.Join(" ", result));

        }
        static int[] MiddleSum(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            if (nums.Length % 2 == 0)
            {
                return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
            }
            else
            {
                return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1] };
            }
        }
    }
}
