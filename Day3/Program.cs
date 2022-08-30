using static System.Console;
using Day3;

Matrix.IntMatrix();
/**
var myMatrix = Matrix.FillRandomMatrix(5,5);
Matrix.DisplayMatrix(myMatrix);

Console.WriteLine();
var diagonal = Matrix.MatrixDiagonal(5,5);
Matrix.DisplayMatrix(diagonal);
**/
/**
Console.WriteLine("Dibawah ini adalah Matrix :");
Console.WriteLine($"Total Hasil Sum diagonal : {sum}");
var Matrixx = Matrix.MatrixSumRandom(5, 5);
Matrix.DisplayMatrix(Matrixx);
**/


/** No.11
Console.Write("dibawah ini matrix dengan : ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] bk = Matrix.MatrixSumRandom(m, m);

var mmyMatrix = Matrix.MatrixNilai(bk,m);
Matrix.DisplayMatrix(mmyMatrix);
**/

Console.Write("dibawah ini matrix dengan akhir yang dijumlah : ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] bk = Matrix.MatrixSumRandom(m, m);

var mmyMatrix = Matrix.MatrixJumlah(bk, m);
Matrix.DisplayMatrix(mmyMatrix);



ReadLine();