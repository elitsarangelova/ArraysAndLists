using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNums = new List<int>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num)==(int)Math.Sqrt(num))
                {
                    squareNums.Add(num);
                    
                }
            }
            squareNums.Sort((a, b) => b.CompareTo(a));
            //squareNums.Sort()//SquareNums.Reverse();
            Console.WriteLine(string.Join(" ", squareNums));

        }
    }
}
