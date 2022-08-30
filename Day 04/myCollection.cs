using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04
{
    internal class myCollection
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A","B", "C", "D", "E"};
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y"});

            foreach (var item in alfabet) 
            {
                Console.Write($"{item} ");
            }

            //remove element from list
            alfabet.Remove("X");
            alfabet.RemoveRange(4, 6);
            alfabet.RemoveAll(v => v == "A");

            //clear
            alfabet.Clear();


            //declare Lint<int>
            var numbers = new List<int> { 2, 5, 7, 11, 13, 17, 19 };
            numbers.Add(23);
            numbers.Remove(13);
            numbers.RemoveAll(v => v >= 7);

            //find element
            var a = numbers.Find(e => e < 10);
            var b = numbers.FindLast(e => e < 11);
            var c = numbers.FindAll(e => e <= 10);

            //link index element
            var d = numbers.FindIndex(e => e <= 11);
            





            
           
        }
        //last in fisrt out
        public static void Stack()
        {
            var number = new Stack<int> (new int[] {1,2,3});
            number.Push(5);
            number.Push(7);

            //remove pop
            number.Pop();
            var n = number.Peek();
            number.Clear();

            
        }

        public static void initDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "JAVA");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "C#" },
                {2, "Java" },
                {3, "Phyton" },
                {4, "Ruby" }
            };

            //add new element
            pl2.Add(5, "Golang");
            pl2.Add(6, "JavaScript");
            pl2.TryAdd(5, "C++");

            pl2[2] = "Wine";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }


            Console.WriteLine();
        }


        //menyimpan uniqe key element
        public static void InitHashset()
        {
            HashSet<int> number = new HashSet<int>() { 1, 2, 3, 5, 8 };
            number.Add(5);
            number.Add(10);
            number.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result1 = new HashSet<int>(hs1);
            result1.IntersectWith(hs2)  ; //inner join resul (1,2)

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2); // Union => 1,2,3,4,5,6,9

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2); // 5,6,9

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2); // 3,4,5,6,9

            //convert hashseet to list
            var myNumber = result4.ToList();


           
            Console.WriteLine();

            

        }



        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Irham");
            queue.Enqueue("Rafi");
            queue.Enqueue("Mahreza");

            Console.WriteLine($"Queue from front to back");
            foreach (var item in queue)
            {
                Console.WriteLine($" {item} ");
            }


            string served = queue.Dequeue();
            Console.WriteLine($" Server  {served}");
        }
        


        //return List<T>
        public static List<T> GetStudent<T>(ref List<T> list)
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
