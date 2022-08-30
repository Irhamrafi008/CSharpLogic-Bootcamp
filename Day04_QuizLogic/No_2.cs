using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_QuizLogic
{
    internal class No_2
    {
        public static void Nomor2()
        {
            var angka = new List<int> { 1, 2, 3, 4 };
            var huruf = new List<string> { "A", "BB", "CCC", "DDDD" };
            foreach (var item in huruf)
            {
                Console.Write(item);
            }
            huruf.Reverse();
            Console.WriteLine();
            foreach (var item in huruf)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in angka)
            {
                Console.Write(item);
            }
            angka.Reverse();
            Console.WriteLine();
            foreach (var item in angka)
            {
                Console.Write(item);
            }
        }


    }
}
