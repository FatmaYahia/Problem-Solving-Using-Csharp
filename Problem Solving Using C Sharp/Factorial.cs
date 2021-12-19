using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                long factorial = 1;
                long n = long.Parse(Console.ReadLine());
                for (long i = n; i > 1; i--)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
                t--;
            }

        }
    }
}
