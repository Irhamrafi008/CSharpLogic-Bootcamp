using static System.Console;
// call  class employee
//using Day4_oop.PartOne;
using Day4_oop.PartTwo;

////setiap create object instance, gunakan operator
////Employee emp1 = new Employee();
//emp1.EmpId1 = 321;
//emp1.FirstName1 = "mahreza";
//emp1.LastName1 = "Rafi";
//emp1.City = "Dari Tadi";
//emp1.JoinDate = DateTime.Now;
//emp1.BasicSalary = 7_000_000;

//emp1.Role = "Programmer";

//create object employee with parameter Constructor
//Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(), 2_000_000);
//emp2.Role = "Perogramer";
//Employee emp3 = new Employee(1002, "Irham", "rafi", new DateTime(2022, 8, 29), 5_000_000, "Jakarta");
//emp3.Role = "Sales";
//Employee emp4 = new Employee(1002, "padil", "rafi", new DateTime(2022, 8, 29), 5_000_000, "utara", "QA");
//emp3.BasicSalary = 3_000_000;

////WriteLine(emp1.ToString());
//WriteLine(emp2.ToString());
//WriteLine(emp3.ToString());
//WriteLine(emp4.ToString());
//WriteLine($" Total Employee : {Employee.totalEmployee}");
//WriteLine($" Total basic Salary : {Employee.totalbasicSalary}");
//WriteLine("==================================================");


//create Object Programmer
//Programmer prog = new Programmer(1001, "iam", "rafi", new DateTime(2022, 8, 11), 6_000_000, " Jakarta ", 500_000);
//Sales sal = new Sales(1003, "Dios", "Syaban", new DateTime(2022, 9, 10), 3_000_000, "Bandung", 00_000, 100_000);
//QA qual = new QA(1004, "Burhan", "Sinyo", new DateTime(2022, 9, 11), 4_500_000, "Sumedang", 10_000);
////Store to list
//List<Employee> ListEmployee = new List<Employee> { emp2, emp3, emp4, prog, sal, qual };
//foreach (var item in ListEmployee)
//{
//    WriteLine(item.ToString());
//}

//Create Object Sales

// gunakan encapsulation  untuk memanipulasi attribute object
//emp1.FirstName = "CodeID";
//emp1.EmpId = 1234;

ReadLine();


////using interface
WriteLine("===============IMPLEMENTASI INTERFACE=================");
//call interface and implementationya

//IEmployee empinf = new EmployeeImpls();
//var listOfEmps = empinf.InitDataEmployee();
//empinf.ShowList(ref listOfEmps);
IEmployee empinf = new EmployeeImpls();
var lisOfEmps = empinf.InitDataEmployee();
empinf.ShowList(ref lisOfEmps);

//var emp = empinf.findEmployeeById(listOfEmps, 1003);
//WriteLine();
//WriteLine($"found : {emp}");

var emp = empinf.findEmployeeById(lisOfEmps, 1003);
WriteLine();
WriteLine($"found : {emp}");

var total = empinf.GetTotalSalary(ref lisOfEmps);
WriteLine($"");
WriteLine($"Total Salary : {total}");

WriteLine("================SALARY RANGE=================");
var empSalaryRange = empinf.FindSalaryRange(lisOfEmps, 3_000_000, 5_500_000);
empinf.ShowList(ref empSalaryRange);

WriteLine("=========findByRole=============");
var byRole = empinf.GetTotalEmployeeByRole(lisOfEmps);
empinf.showRole(byRole);


//ReadLine();
