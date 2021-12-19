using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class The_Brothers
    {
        static void Main(string[] args)
        {
            string s1, f1, s2, f2;
            string line = Console.ReadLine();
            string line2 = Console.ReadLine();
            string[] name1 = line.Split(' ');
            string[] name2 = line2.Split(' ');
            f1 = name1[0];
            s1 = name1[1];
            f2 = name2[0];
            s2 = name2[1];
            if (s1 == s2)
            {
                Console.WriteLine("ARE Brothers");
            }
            else
            {
                Console.WriteLine("NOT");
            }

        }

    }
}
