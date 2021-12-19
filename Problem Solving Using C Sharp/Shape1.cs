using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Shape1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
