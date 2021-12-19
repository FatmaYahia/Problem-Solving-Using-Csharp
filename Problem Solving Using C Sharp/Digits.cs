using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Digits
    {
        static void Main(string[] args)
        {
            int div, mod;
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());

                div = n;
                while (div > 0)
                {
                    mod = div % 10;
                    div /= 10;
                    Console.Write($"{mod} ");
                }
                if (n == 0)
                {
                    Console.Write(0);
                }

                Console.WriteLine();
                t--;
            }

        }
    }
}
