using static System.Console;
using Day4_OOP_QUIZ.Obj_Car;


//SUV mb1 = new SUV("D 1001 UM", 2015, "SUV", 500_000, 100_000);
//SUV mb2 = new SUV("D 1002 UM", 2015, "SUV", 500_000, 100_000);

//Taxi tx1 = new Taxi("D 88 UK", 2018, "TAXI", 5, 4_500, 40, 10_000);
//Taxi tx2 = new Taxi("D 87 UK", 2018, "TAXI", 10, 4_500, 100, 10_000);

//angkot ang1 = new angkot("D 55 UJ", 2016, "Angkot", 4_500, 35);
//angkot ang2 = new angkot("D 55 UJ", 2015, "Angkot", 4_500, 40);

//List<Cars> Listcar = new List<Cars> { mb1,mb2,tx1,tx2,ang1, ang2};
//foreach (var item in Listcar)
//{
//    WriteLine($"{item.ToString()}");
//}



WriteLine("=========== SUMARY ============");
ICars carinf = new CarsImpls();
var listcar = carinf.initDataCars();
carinf.ShowList(ref listcar);

WriteLine("========TotalCarbyType=========");

var carType = carinf.DictionaryCars(listcar);
carinf.showCarType(carType);

Console.WriteLine("============TotalRevenueCar===========");
var carRevenue = carinf.CarRevenueType(listcar);
carinf.showTotalCarRevenue(carRevenue);

Console.WriteLine("==============FindRevenueByRange==========");
var carRange = carinf.FindRevenueByRange(listcar, 500_000, 600_000);
carinf.ShowList(ref carRange);
ReadLine();