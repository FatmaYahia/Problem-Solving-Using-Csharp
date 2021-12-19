using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class PUM
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n * 4; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("PUM");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
