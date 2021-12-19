using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Max_Subarray
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                string line = Console.ReadLine();
                string[] nums = line.Split(' ');
                for(int i = 0; i < nums.Length; i++)
                {
                    a[i] = int.Parse(nums[i]);
                }
                for(int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);

                }
                t--;
            }
        }
    }
}
