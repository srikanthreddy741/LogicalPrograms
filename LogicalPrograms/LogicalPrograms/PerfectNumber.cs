using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void FindingPerfectNumber()
        {
            int n, i, sum;
            int min, max;

            Console.WriteLine("Find the Perfect Number within a given number of range:\n");

            Console.WriteLine("Input the Starting range of number :");

            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Ending range of number :");

            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect number within the given range :");

            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
        }
    }
}
    

