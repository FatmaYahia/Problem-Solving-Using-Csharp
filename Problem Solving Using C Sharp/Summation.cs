using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Summation
    {
        static void Main(string[] args)
        {
            long n, sum = 0;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(numbers[i]);
                sum += a[i];
            }
            if (sum < 0)
            {
                Console.WriteLine(sum * -1);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
