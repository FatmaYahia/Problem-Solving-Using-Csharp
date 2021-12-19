using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class GCD
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            if (a < b)
            {
                for (int i = a; i >= 1; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            else
            {
                for (int i = b; i >= 1; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
