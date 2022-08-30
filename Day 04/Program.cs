using static System.Console;
using Day_04;

myCollection.InitList();
myCollection.Stack();
myCollection.initDictionary();
myCollection.InitHashset();
myCollection.InitQueue();


//declare List<T>
var List = new List<string> { "irham", "rafi", "mahreza" };
var student = myCollection.GetStudent(ref List);

foreach (var item in student)
{
    Console.WriteLine($"{item}  "); 
}

var numbers = new List<int> { 2, 3, 4, 5, 6 };
var myNumber = myCollection.GetStudent(ref numbers);
foreach (var item in numbers)
{
    Console.WriteLine($" {item} ");
}


ReadLine();