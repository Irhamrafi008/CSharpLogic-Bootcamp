using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02
{
    internal class ArrayCase
    {
        public static void IntroArray()
        {
            //declare array with in data Type
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 12;
            arrInt[1] = 45;
            arrInt[3] = 50;
            arrInt[4] = 1_000_000;
            //arrINt[6] = 90;

            // int array with string data
            string[] listOfGirl = new string[] { "yuli", "Rini", "widi" };

            //display Array
            foreach (var item in listOfGirl)
            {
                Console.WriteLine($"{item}");
            }
            for (int i = 0; i < listOfGirl.Length; i++)
            {
                Console.WriteLine(listOfGirl);
            }
        }

        //method return or function inarput array

        public static int[] initArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }

        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        //initial value with random
        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }

            return arr;
        }

        //Sum All array Elemnent
        public static double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int FindmaxElement(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

    }
}
