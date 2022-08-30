using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01
{
    internal class MathCase
    {
        /** Case 1 : input bilangan 3 digit . lalu konversi ke dolar
         * inpupt : 75000, output : Rp. 50 = 10, Rp. 30 = 0, Rp. 20 = 1
         * */

        public static void ATM()
        {
            int digit1,digit2, digit3,sisa;
            Console.Write("Enter Money : ");
            int number = Convert.ToInt32(Console.ReadLine());
            digit1 = number / 50_000;
            sisa = number % 50_000;

            digit2 = sisa / 10_000;
            sisa = sisa % 10_000;

            digit3 = sisa / 5_000;
            sisa = sisa % 5_000;

            Console.WriteLine($"Rp.50rb = {digit1}, Rp. 10rb = {digit2}, Rp.5rb {digit3}, Sisa = {sisa}");       
        }


        /** input bilangan 2345
         *  output nya 2+3+4+5 = 14
         * */
        public static void SumDigit()
        {
            int digit1,digit2, digit3,r;
            Console.Write("Enter 4 digit number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r = r % 100;

            digit3 = r / 10;
            r = r % 10;

            int sum = digit1 + digit2 + digit3 + r;
            //Console.WriteLine($"Total Sum : {sum}");
            Console.WriteLine("Total Sum :" + sum);
        }

        /** input bilangan 2345
        *  output nya 5+4+3+2 = 14
        * */
        public static void ReverseSum()
        {
            int digit1, digit2, digit3, r;
            Console.Write("Enter 4 digit number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r = r % 100;

            digit3 = r / 10;
            r = r % 10;

            string reverse = r + "" + digit3 + "" + digit2 + "" + digit1;
            //Console.WriteLine($"Total Sum : {sum}");
            Console.WriteLine("reverse Sum :" + reverse);
            Console.WriteLine($"Reverse Sum : {reverse}");
        }

        /** FizzBuzz
         * Kelipatan 3 & 5 output FizzBuzz
         *  Kelipatan 3 output Fizz
         *  kelipatan 5 ouput Buzz
         *  not 3 & 5 output number
         *  */

        public static void FizzBuzz ( int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else
                    Console.WriteLine(i);
            }
        }

        //is Prime

        public static bool isPrime(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if( n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }


}
