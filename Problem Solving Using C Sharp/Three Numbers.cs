using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Three_Numbers
    {
        static void Main(string[] args)
        {
            int k, s, count = 0;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            k = int.Parse(numbers[0]);
            s = int.Parse(numbers[1]);
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    int z = s - (i + j);
                    if (z >= 0 && z <= k)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
