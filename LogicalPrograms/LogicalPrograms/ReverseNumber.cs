using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void PrintTheReverseNumber()
        {
            int n, reverse = 0, remainder = 0;
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                remainder = n % 10;

                reverse = reverse * 10 + remainder;

                n = n / 10;
            }
            Console.WriteLine("Reverse Number is: " + reverse);
        }
    }
}
