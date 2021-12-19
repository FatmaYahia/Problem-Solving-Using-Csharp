using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class First_digit__
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x / 1000 % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}
