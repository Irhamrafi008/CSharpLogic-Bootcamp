using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace QuizLogic.LogicTest
{
    internal class LogicTests
    {
        //Soal No.1
        //Buat program untuk menghitung summary
        public static void SumDigitNo_1()
        {
            int sum = 0;
            Console.Write("Enter Number Integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum += (number % 10);
                number /= 10;

            }
            Console.WriteLine($"Total Sum : {sum}");

        }

        //Soal No.2
        //Buat program untuk menghitung jumlah digit yang diinput
        public static void JumlahDigit()
        {
            int count = 0;
            Console.Write("Enter Number Integer : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit = 0;

            while(number > 0)
            {
                count += (number % 10);
                number /= 10;
                digit++;
            }
            Console.WriteLine($"Count : {digit}");
        }

        //Soal No.3
        //Buat program dengan inputan integer
        public static void IntegerInput()
        {
            int hasil = 0;
            Console.Write("Enter Number Integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                hasil = (number % 10);
                number /= 10;

                Console.Write($"{hasil}");
            }
            
        }

        //Soal No.4
        //Buat program untuk menampilkan bilangan terbesar kedua dengan inputan dinamis

        public static void MaxValue()
        {
            int max = 0;
            Console.Write("Masukan Angka Terbesar LOOP : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                max++;
            } Console.WriteLine($"Angka ke-2 Terbesar : {max}");
        }

        //Soal No.5
        /**program GuessNumber, dimana user input angka untuk menebak random number, jika 
        benar munculkan return message**/
        public static void GuesNumber()
        {
            Console.WriteLine("Guess Magic Number between 0 - 20 :");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;
            while (guess != number)
            {
                Console.Write("Enter Your guess :");
                var input = Console.ReadLine();

                int.TryParse(input, out guess);

                //cek kondisi

                if (guess == number)
                {
                    Console.Write($"You're right number : {guess}");
                    Console.Write("pilih lagi");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        GuesNumber();
                    } else if(key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("quit");
                        break;
                    }
                } else if (guess > number)
                {
                    Console.WriteLine("Your guess is to high . Try Again");
                } else
                {
                    Console.WriteLine("guess to low");
                }
            }
            

          
        }

        //Soal No.6
        //program menampilkan angka terbesar
        public static void AngkaTerbesar()
        {
            int max = 0;
            int number = 0;

            for (int i = 0; i >= number; i++)
            {
                Console.Write("Enter Angka [type 0 for exit] : ");
                int angka = Convert.ToInt32(Console.ReadLine());
                if (angka > max)
                {
                    max = angka;

                } else if (number == 0)
                {
                    Console.Write($"{max}");
                    break;
                }
               
            }
        }

        //Soal No.7
        //program untuk menampilkan angka pembagi dari sebuah bilangan
        public static void BilanganPembagi()
        {
            Console.Write("Enter Number :");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {  
                    Console.WriteLine(i + "");
                }

            }
        }

        //Soal No.8
        // Buat program untuk menampilkan bilangan prima dalam range tertentu
        public static void BilanganPrima()
        {
            Console.Write("Enter Limit Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                int jumlah = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        jumlah++;
                    }
                } if (jumlah == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }


        //Soal No.9
        //Buat program untuk menampilkan bilangan terbesar kedua dengan inputan dinamis
        public static void palindrome()
        {
            Console.WriteLine("masukan Kata Palindrom : ");
            string kata = Convert.ToString(Console.ReadLine());
            kata.ToLower();
            string kalimat = "";

            for (int i = 0; i < kata.Length; i++)
            {
                kalimat += kata[i].ToString();
            }

            if (kata == kalimat)
            {
                Console.WriteLine("Kata ini adalah palindrom");
            }
            else
            {
                Console.WriteLine("kata ini bukan palindrom");
            }


        }

        //Soal No.10
        //program untuk menghitung jumlah huruf vocal dan consonant
        public static void VocalConsonant()
        {
            int vokal = 0;
            int konsonan = 0;
            Console.Write("Enter Strings : ");
            string kata = Convert.ToString(Console.ReadLine());
            string kalimat = "";

            for (int i = 0; i < kata.Length ; i++)
            {
                kalimat = kata[i].ToString();
               if ( kalimat == "a" || kalimat == "i" || kalimat =="u" || kalimat == "e" || kalimat == "o")
                {
                    vokal++;
                }
                else 
                {
                    konsonan++;
                }
            }

            Console.WriteLine($" huruf Vokal : {vokal}");
            Console.WriteLine($" huruf konsonan : {konsonan}");


        }

        //Soal No.11
        // program untuk menghitung jumlah kata dalam kalimat yang diinput
        public static void KalimatInput()
        {
            Console.Write("Enter Strings : ");
            string kata = Convert.ToString(Console.ReadLine());
            string spasi = "";
            int count = 1;

            for (int i = 0; i < kata.Length; i++)
            {   
                spasi = kata[i].ToString();
                if(spasi == " ")
                {
                    count++;   
                }
            }
            Console.Write($"Total kata : {count}");
        }


        //Soal No.12
        //program untuk mereplace middle character menjadi symbol * dalam sebuah kalimat
        public static void SymbolCharacter()
        {

        }





        //Soal No.13
        //program untuk menampilkan berapa hari lagi ke hari jumat
        public static void DateDays()
        {
            DateTime now = DateTime.Now;

            DayOfWeek sekarang = now.DayOfWeek;
            DayOfWeek jumat = DayOfWeek.Friday;


            int hari = jumat - sekarang;
            Console.WriteLine(now.AddDays(hari));
            Console.Write($" {hari} hari lagi !!!!");



            
        }

        //D
    }
}
