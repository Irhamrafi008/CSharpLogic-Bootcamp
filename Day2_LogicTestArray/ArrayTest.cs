using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day2_LogicTestArray
{
    internal class ArrayTest
    {
        //Soal No.1
        //Buat program untuk menampilkan array dimana position index-nya bisa diacak (random)
        public static int[] InitArrayInt(int[] arr)
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

        //bilangan Random
        public static int[] ArrayRandom(int[] n)
        {
            int[] arr = n;
            Random rand = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                int var = arr[i];
                int j = rand.Next(0, n.Length);
                arr[i] = arr[j];
                arr[j] = var;
            }

            return arr;
        }


        //Soal No.2
        //program untuk menggeser element pertama ke element terakhir, dan menggeser 
        //element kedua sampai element terakhir maju ke depan
        
        public static int[] Shifting(int[] n)
        {
            int[] arr = n;
            int awal = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                int j = arr[i];
                if (i < n.Length - 1)
                {
                    arr[i] = n[i + 1];
                }else
                {
                    arr[i] = awal;
                }
            }
            return arr;
        }

        //Soal No.3
        //Masih seperti kasus nomor 2, sekarang buat program untuk rotasi array ke kiri sebanyak n

        public static int[] ShiftingTerus(int[] n)
        {
            int[] arr = n;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotate Shiting ke - {i}");
                int rotate = n[0];
                for (int j = 0; j < n.Length - 1; j++)
                {
                   arr[j] = n[j + 1];
                }
                arr[n.Length -1] = rotate;
                DisplayArrayInt(arr);
                n = arr;
            }
               

            
            return arr;

        }

        //soal No.4
        //Seperti contoh kasus nomor 3, buat program untuk rotasi array ke kanan sebanyak n kali
        public static int[] RotasiKanan(int[] n)
        {
            int[] arr = n;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotate Shiting ke - {i}");
                int rotate = n[n.Length -1];
                for (int j = n.Length -1 ; j > 0 ; j--)
                {
                  
                    arr[j] = n[j - 1];
                }
                arr[0] = rotate;               
                DisplayArrayInt(arr);
                n = arr;
            }

            return n;
        }

        //soal no.5 (belom kelar)
        //program untuk menghitung jumlah angka yang muncul dalam array
        public static int[] JumlahMuncul(int[] n)
        {
            int[] arr = n;
            Array.Sort(arr);
            int nilai = 0;
            int count;

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                       count++;

                    }
                }
                if (i < arr.Length - 1 && arr[i] != arr[i + 1])
                {
                    Console.WriteLine($"{arr[i]} muncul {count} kali");
                }
                else if (i == arr.Length - 1)
                {
                    Console.WriteLine($"{arr[i]} muncul {count} kali");
                }
                

            }

            return arr;
        }



        //Soal No.6
        //program untuk merubah angka duplikat menjadi -1 dalam sebuah array


        //Soal no.7
        // program untuk menghapus duplicate element dalam array
        public static int[] RemoveDuplicate(int[] n)
        {
            int[] arr = n;
        
            int r = 0;

            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n.Length; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        j--;
                        
                    }
                }
            }
            return arr;
        }

        //Soal 8
        //program untuk menghitung jumlah tiap karakter dari 100 huruf karakter bertipe char 
        //yang disimpan dalam sebuah array
        public static char[] JumlahHuruf(char n)
        {
            char[] arr = new char[n];
            int count = 0;
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                _ = arr[i] == arr[rand.Next(i)];
            }

            return arr;
        }



    }
}
