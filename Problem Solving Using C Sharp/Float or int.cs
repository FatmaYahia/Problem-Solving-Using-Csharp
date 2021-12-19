using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Float_or_int
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int value = Convert.ToInt32(Math.Floor(n));
            double rem;
            rem = n - value;
            if (rem == 0)
            {
                Console.WriteLine($"int {value}");
            }
            else
            {
                Console.WriteLine($"float {value} {rem}");
            }
        }
    }
}
