using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Reversing
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(nums[i]);
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
