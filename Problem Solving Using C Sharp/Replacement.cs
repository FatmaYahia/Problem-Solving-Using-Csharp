using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Replacement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(nums[i]);
                if (a[i] > 0)
                {
                    a[i] = 1;
                }
                else if (a[i] < 0)
                {
                    a[i] = 2;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }

        }
    }
}
