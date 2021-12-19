using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Digits_Summation
    {
        static void Main(string[] args)
        {
            long n, m;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            n = long.Parse(numbers[0]);
            m = long.Parse(numbers[1]);
            Console.WriteLine((n % 10) + (m % 10));
        }
    }
}
