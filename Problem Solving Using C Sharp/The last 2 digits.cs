using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class The_last_2_digits
    {
        static void Main(string[] args)
        {
            long a, b, c, d, x;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);
            c = int.Parse(numbers[2]);
            d = int.Parse(numbers[3]);
            x = (a % 100 * b % 100 * c % 100 * d % 100) % 100;
            if (x < 10)
            {
                Console.Write($"0");
            }
            Console.WriteLine(x);


        }
    }
}
