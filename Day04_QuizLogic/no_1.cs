using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_QuizLogic
{
    internal class no_1
    {
        //No.1
        public static void nomor1()
        {
            var numbers1 = new List<int> { 1, 2, 5, 6, 9 };
            var number2 = new List<int> { 1, 2, 3, 4 };
            Console.Write("input A :");
            foreach (var item in numbers1)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            Console.Write("input B :");
            foreach (var item in number2)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            var result1 = new HashSet<int>(numbers1);
            result1.IntersectWith(number2);
            Console.Write("Element yang sama antara A dan B: ");
            foreach (var item in result1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            var result2 = new HashSet<int>(numbers1);
            result2.UnionWith(number2);
            Console.Write("Merge dan tampilan Element pada A dan B : ");
            foreach (var item in result2)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            var result3 = new HashSet<int>(numbers1);
            result3.ExceptWith(number2);
            Console.Write("Element di A yang tidak sama dengan B : ");
            foreach (var item in result3)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            var result4 = new HashSet<int>(numbers1);
            result4.SymmetricExceptWith(number2);
            Console.Write("Element yang tidak sama dengan A & B : ");
            foreach (var item in result4)
            {
                Console.Write($" {item} ");
            }

        }


        public static List<T> CollectionNumber<T>(ref List<T> list)
        {
          var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }

    }
}
