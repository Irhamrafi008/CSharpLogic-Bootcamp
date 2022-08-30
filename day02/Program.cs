using static System.Console;
using day02;

//AraryCase.IntroArray();

//call function
int[] n = { 10, 20, 30 };
var myArray = ArrayCase.initArrayInt(n);

ArrayCase.DisplayArrayInt(myArray);
WriteLine();



var myRandom = ArrayCase.InitArrayRandom(20);

ArrayCase.DisplayArrayInt(myRandom);
Console.WriteLine();
WriteLine($"Total Sum Random ={ArrayCase.SumAllElement(myRandom)}");

WriteLine($"Nilai Tertinggi = {ArrayCase.FindmaxElement(myRandom)}");

//Copy Array dari myRandom to New aarray
int[] newArray2 = new int[myRandom.Length];
for (int i = 0; i < newArray2.Length; i++)
{
    newArray2[i] = myRandom[i];
}
ArrayCase.DisplayArrayInt(newArray2);

WriteLine();

//sort Array
Array.Sort(newArray2);
ArrayCase.DisplayArrayInt(newArray2);

WriteLine();

//Menggunakan Method 
var randomArray = new int[myRandom.Length];
Array.Copy(newArray2, 0, randomArray,0, myRandom.Length);
Array.Reverse(newArray2);
ArrayCase.DisplayArrayInt(newArray2);




ReadLine();
