using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RemoveNegatievsAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            foreach (var num in nums)
            {
                if (num >= 0)
                {
                    list.Add(num);
                }
            }
            if (list.Count > 0)
            {
                list.Reverse();
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
