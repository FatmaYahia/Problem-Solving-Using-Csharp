using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class One_Prime
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int flag = 0;
            if (x % 2 != 0 || x == 2)
            {
                for (int i = 3; i < x / 2; i += 2)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine("NO");
                        flag = 1;
                        break;
                    }
                }

                if (flag != 1)
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
