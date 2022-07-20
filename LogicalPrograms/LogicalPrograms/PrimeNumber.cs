using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void PrintThePrimeNum()
        {
            int n, i, flag = 0;
            int min, max;

            Console.WriteLine("Find the Prime number within a given range of number");

            Console.WriteLine("Input starting number of range:");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Ending number of range:");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers within the given range");

            if (min >= 2)
            {
                for (n = min; n <= max; n++)
                {
                    i = 2;
                    flag = 0;

                    while (i <= n / 2)
                    {
                        if (n % i == 0)
                        {
                            flag = 1;
                            break;

                        }
                        i = i + 1;
                    }
                    if (flag == 0)
                        Console.Write("{0} ", n);
                }

            }

        }
    }
}
