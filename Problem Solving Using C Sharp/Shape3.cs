using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Shape3
    {

        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {

                for (int x = n; x > i; x--)
                {
                    Console.Write(" ");
                }
                for (int k = i * 2 - 1; k >= 1; k--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
