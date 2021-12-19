using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Lucky_Numbers
    {
        static void Main(string[] args)
        {
            int div, mod;
            bool isstop = false;
            bool islucky = true;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            for (int i = a; i <= b; i++)
            {
                div = i;
                while (div > 0)
                {
                    mod = div % 10;
                    div = div / 10;
                    if (mod == 4 || mod == 7)
                    {
                        islucky = true;
                        if (div == 0)
                        {
                            isstop = true;
                            Console.Write($"{i} ");
                        }
                    }
                    else
                    {
                        islucky = false;
                        break;
                    }

                }

            }
            if (islucky == false && isstop == false)
            {
                Console.WriteLine("-1");

            }
        }
    }
}
