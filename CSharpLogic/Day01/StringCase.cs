using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class StringCase
    {
        public static void StringsCase()
        {
            //SubString
            string word = "Code Academy Bootcamp";
            string cutWord = word.Substring(5, 7);
            Console.WriteLine(cutWord);
            Console.WriteLine($"{word} length = {word.Length}");
            Console.WriteLine($"{word.Replace("code", "Code.Id")}");

            string cutAcademy = word.Substring(word.IndexOf("Academy"), 7);
            Console.WriteLine($"cutAcademy : {cutAcademy}");
        }

        //Word = ABC; output = CBA
        public static string ReverseString(string word)
        {
            string reverse = "";
            char[] chars = word.ToCharArray();
            reverse = reverse + chars.ElementAt(0);
            reverse += chars.ElementAt(1);
            reverse += chars.ElementAt(2);
            return reverse;
        }

        public static StringBuilder ReverseStringBuilder (string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = word.ToCharArray ();
            sb.Append(chars.ElementAt(2));
            sb.Append(chars.ElementAt(1));
            sb.Append(chars.ElementAt(0));
            return sb;
        }




    }
}
