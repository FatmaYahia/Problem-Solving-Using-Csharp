using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Some_Sums
    {
        static void Main(string[] args)
        {
            int a, b, n, divison, mod, sum, total = 0;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            n = int.Parse(numbers[0]);
            a = int.Parse(numbers[1]);
            b = int.Parse(numbers[2]);
            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                divison = i;
                while (divison > 0)
                {
                    mod = divison % 10;
                    divison /= 10;
                    sum += mod;
                }
                if (sum >= a && sum <= b)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
