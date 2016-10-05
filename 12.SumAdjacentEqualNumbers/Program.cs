using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
