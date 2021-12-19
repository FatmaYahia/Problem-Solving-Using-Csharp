using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Primes_from_1_to_n
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int flag;
            if (n >= 2)
            {
                Console.Write("2 ");
            }
            for (int j = 3; j <= n; j += 2)
            {
                flag = 0;
                for (int i = 3; i < j / 2; i += 2)
                {
                    if (j % i == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    Console.Write($"{j} ");
                }
            }
        }
    }
}
