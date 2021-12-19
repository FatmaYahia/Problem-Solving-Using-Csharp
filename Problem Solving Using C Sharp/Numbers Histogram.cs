using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Numbers_Histogram
    {
        static void Main(string[] args)
        {
            char s = char.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] n = line.Split(' ');
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < int.Parse(n[i]); j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
