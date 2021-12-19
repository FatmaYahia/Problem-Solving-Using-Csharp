using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Summation_from_1_to_N
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long sum;
            sum = (n * (n + 1)) / 2;
            Console.WriteLine(sum);
        }
    }
}
