using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Sum_of_Consecutive_Odd_Numbers
    {
        static void Main(string[] args)
        {
            int t, a, b, sum;
            t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                a = int.Parse(numbers[0]);
                b = int.Parse(numbers[1]);
                sum = 0;
                if (a <= b)
                {
                    for (int i = a + 1; i < b; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += i;
                        }
                    }
                    Console.WriteLine(sum);

                }
                else
                {
                    for (int i = b + 1; i < a; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += i;
                        }
                    }
                    Console.WriteLine(sum);

                }
                t--;
            }

        }
    }
}

