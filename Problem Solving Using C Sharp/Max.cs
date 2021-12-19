using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Max
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int x = int.Parse(numbers[i]);
                if (x >= max)
                {
                    max = x;
                }
            }
            Console.WriteLine(max);
        }
    }
}
