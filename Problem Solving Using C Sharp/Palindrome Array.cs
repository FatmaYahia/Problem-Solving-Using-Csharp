using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Palindrome_Array
    {
        static void Main(string[] args)
        {
            bool ispalindrome = false;
            bool isnotpalindrome = false;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int index = a.Length - 1;
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            for (int i = 0; i < nums.Length; i++)
            {
                a[i] = int.Parse(nums[i]);
            }
            for (int j = 0; j < a.Length / 2; j++)
            {
                if (a[j] == a[index - j])
                {
                    ispalindrome = true;
                }
                else
                {
                    isnotpalindrome = true;
                }
            }
            if (isnotpalindrome == true)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");

            }
        }
    }
}
