using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Age_in_Days
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n / 365} years");
            Console.WriteLine($"{(n % 365) / 30 } months");
            Console.WriteLine($"{(n % 365) % 30} days");

        }
    }
}
