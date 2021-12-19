using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Sorting
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            for (int i = 0; i < nums.Length; i++)
            {
                a[i] = int.Parse(nums[i]);
            }
            for (int x = 0; x < a.Length; x++)
            {
                for (int y = x + 1; y < a.Length; y++)
                {
                    if (a[x] > a[y])
                    {
                        int temp;
                        temp = a[x];
                        a[x] = a[y];
                        a[y] = temp;
                    }
                }
            }
            for (int z = 0; z < a.Length; z++)
            {
                Console.Write($"{a[z]} ");
            }
        }
    }
}
