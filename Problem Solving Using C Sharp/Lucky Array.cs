using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Lucky_Array
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue, count = 0;
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
                if (a[x] < minNum)
                {
                    minNum = a[x];
                }
            }
            for (int y = 0; y < a.Length; y++)
            {
                if (a[y] == minNum)
                {
                    count++;
                }
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("Unlucky");
            }
            else
            {
                Console.WriteLine("Lucky");
            }
        }
    }
}
