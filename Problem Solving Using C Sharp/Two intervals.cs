using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Two_intervals
    {
        static void Main(string[] args)
        {

            string Line = Console.ReadLine();
            string[] Numbers = Line.Split(' ');
            long l1 = long.Parse(Numbers[0]);
            long r1 = long.Parse(Numbers[1]);
            long l2 = long.Parse(Numbers[2]);
            long r2 = long.Parse(Numbers[3]);
            if (r1 >= l2 && r1 <= r2 && l1 <= l2)
            {
                Console.WriteLine($"{l2} {r1}");

            }
            else if (r1 >= l2 && r1 >= r2 && l1 <= l2)
            {
                Console.WriteLine($"{l2} {r2}");

            }
            else if (r1 >= l2 && r1 <= r2 && l1 <= r2)
            {
                Console.WriteLine($"{l1} {r1}");

            }
            else if (r1 >= l2 && r1 >= r2 && l1 <= r2)
            {
                Console.WriteLine($"{l1} {r2}");

            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
