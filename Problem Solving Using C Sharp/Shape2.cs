using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Shape2
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = N; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {

                    Console.Write(" ");
                }
                for (int k = i * 2 - 1; k <= N * 2 - 1; k += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
