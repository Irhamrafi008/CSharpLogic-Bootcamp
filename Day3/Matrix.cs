using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Matrix
    {
        public static void IntMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;

        }

        public static int[,] FillRandomMatrix(int baris,int kolom)
        {
            int[,] matrix = new int[baris,kolom];
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++) // i baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // j kolom
                {
                    matrix[i, j] = rand.Next(20);
                }
            }

            return matrix;
        }

        public static int[,]  MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 3;
            //fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //diagonal 
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }else if ( j > i)
                    {
                        matrix[i, j] = 10;
                    }else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }

        //No.10 
        //program untuk menghitung total angka diagonal dari matrix
        //isi value matrix secara random

        public static int[,] MatrixSumRandom(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random rand = new Random();
            double sum = 0;
       
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(100);
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                    else if(i < j)
                    {
                        matrix[i, j] = 20;
                    }else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }

                }
               
            }

            return matrix;

        }

        //No.11
        // program untuk menampilkan matrix seperti n=7
        public static int[,] MatrixNilai(int[, ] b,int k)
        {
            int[,] matt = new int[b.GetLength(0), b.GetLength(1)];
            double sum = 0;
            
            
            for (int i = 0; i < matt.GetLength(0)  ; i++)
            {
              
                
                for (int j = 0; j < matt.GetLength(1) ; j++)
                {
                    if (i == 0 ||  j==0 || j==k -1 || i == k -1 )
                    {
                        matt[i, j] = i+j;
                    }
                }
            }


            return matt;
        }

        //Soal 12
        //program untuk menampilkan matrix penjumlahan sampai indek terakhir

        public static int[,] MatrixJumlah(int[,] b, int k)
        {           
            int sum = 0;
            int s = 0;
            int ne = b.GetLength(0) - 1;
            int[,] baru = new int[b.GetLength(0), b.GetLength(1)];
            int[,] bar = new int[b.GetLength(0), b.GetLength(1)]; 


            for (int i = 0; i < b.GetLength(0); i++)
            {


                for (int j = 0; j < b.GetLength(1); j++)
                {
                   if(i<ne && j < ne)
                    {
                        bar[i, j] = i + j;
                    }
                }
            }
            baru = bar;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (i !=ne || j != ne)
                    {
                        sum += bar[i, j];
                        baru[ne, i] = baru[i, ne] = sum;
                        if (i == j)
                        {
                            s += bar[i, j];
                            baru[ne, ne] = s;
                        }
                        if ( j == ne - 1)
                        {
                            sum = 0;
                        }
                        
                    }
                }
            }


            return baru ;
        }

        

        //No.13
        //public static int[,] matrixBilangan(int[,] mattrix)
        //{
        //    int[,] matt = mattrix;

        //    for (int i = 0; i < matt.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matt.GetLength(1); j++)
        //        {
        //            if ()
        //        }
        //    }
        //    return matt;
        //}



        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix [i, j] + " \t");
                }
                Console.WriteLine();
            }
        }


    }
}
