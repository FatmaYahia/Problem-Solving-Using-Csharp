using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Multiples
    {
        static void Main(string[] args)
        {
            int a, b;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("No Multiples");
            }
        }
    }
}
