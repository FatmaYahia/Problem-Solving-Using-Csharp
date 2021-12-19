using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Sequence_of_Numbers_and_Sum
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            while (true)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                a = int.Parse(numbers[0]);
                b = int.Parse(numbers[1]);
                sum = 0;
                if (a <= 0 || b <= 0)
                {
                    break;
                }
                else if (a <= b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine($"sum ={sum}");
                }
                else if (b <= a)
                {

                    for (int i = b; i <= a; i++)
                    {
                        sum += i;
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine($"sum ={sum}");
                }
            }
        }
    }
}
