﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CondenceArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (nums.Length >= 2)
            {
                var result = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    result[i] = nums[i] + nums[i + 1];
                }
                nums = result;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
