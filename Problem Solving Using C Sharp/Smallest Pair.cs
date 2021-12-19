using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Smallest_Pair
    {
        static void Main(string[] args)
        {
            int sum;
            int minNum;
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                minNum = int.MaxValue;
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
                        sum = 0;
                        sum = a[x] + a[y] + (y + 1) - (x + 1);
                        if (sum < minNum)
                        {
                            minNum = sum;
                        }
                    }
                }
                Console.WriteLine(minNum);
                t--;
            }
        }
    }
}
