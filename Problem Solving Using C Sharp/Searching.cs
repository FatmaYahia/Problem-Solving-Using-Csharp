using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Searching
    {
        static void Main(string[] args)
        {
            int n, x;
            bool found = false;
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            x = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(nums[i]);
                if (a[i] == x)
                {
                    found = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine(-1);
            }


        }
    }
}
