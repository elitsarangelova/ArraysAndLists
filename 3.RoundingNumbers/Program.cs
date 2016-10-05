using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine()); // броя на елемнтите
            long k = long.Parse(Console.ReadLine());
            long[] array = new long[n];//масив, редица N елементи
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0; //пази сумата на предишните елементи
                long count = k;//запазваме сумата на K
                for (int j = i - 1; j >= 0; j--)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    sum += array[j];
                    count--;//на всяка стъпка намаляме k с единица
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
