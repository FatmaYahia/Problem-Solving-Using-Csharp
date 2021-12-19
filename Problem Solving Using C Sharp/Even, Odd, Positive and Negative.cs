using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Even__Odd__Positive_and_Negative
    {
        static void Main(string[] args)
        {
            int even = 0, odd = 0, positive = 0, negative = 0;
            int N = int.Parse(Console.ReadLine());
            string x = Console.ReadLine();
            string[] numbers = x.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                int z = int.Parse(numbers[i]);
                if (z % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                if (z > 0)
                {
                    positive++;
                }
                else if (z < 0)
                {
                    negative++;
                }

            }
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
            Console.WriteLine("Positive: " + positive);
            Console.WriteLine("Negative: " + negative);
        }
    }
}
