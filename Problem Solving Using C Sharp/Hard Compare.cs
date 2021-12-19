using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Hard_Compare
    {
        static void Main(string[] args)
        {
            long a, b, c, d;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = long.Parse(numbers[0]);
            b = long.Parse(numbers[1]);
            c = long.Parse(numbers[2]);
            d = long.Parse(numbers[3]);
            if ((b * Math.Log(a)) > d * Math.Log(c))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
