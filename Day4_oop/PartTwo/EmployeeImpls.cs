using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.PartTwo
{
    internal class EmployeeImpls : IEmployee
    {
        public Employee findEmployeeById(List<Employee> list, int id)
        {
            Employee? emp = null;
            foreach (var item in list)
            {
                if(item.EmpId1 == id)
                {
                    emp = item;
                }
            }
      
            return emp;
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal StartFrom, decimal EndTo)
        {
            var empRange = new List<Employee>();

            foreach (var item in list)
            {
                if(item.TotalSalary >= StartFrom && item.TotalSalary <= EndTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;

            //throw new NotImplementedException();
        }

        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
        {
            var empRole = new Dictionary<string, int>();
            int counProg = 0;
            int countSal = 0;
            int countQa = 0;
            foreach (var item in list)
            {
                if (item.Role == "Programmer")
                {
                    counProg++;
                }
                else if ( item.Role == "Sales")
                {
                    countSal++;
                }
                else if( item.Role == "QA")
                {
                    countQa++;
                }
            }
            empRole.Add("Programmer", counProg);
            empRole.Add("Sales", countSal);
            empRole.Add("QA", countQa);
            return empRole;
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {

            var total = 0M;
            //offType digunakan jika data yang diikirim generic dan kita ingin akses attribute
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalary;
            }
            return total;
            //throw new NotImplementedException();
        }

        public List<Employee>   InitDataEmployee()
        {
            Employee emp1 = new Employee(1001, "Code", "Academy", new DateTime(), 2_000_000);
            
            Employee emp2 = new Employee(1002, "Irham", "rafi", new DateTime(2022, 8, 29), 5_000_000, "Jakarta");
            
            Employee emp3 = new Employee(1002, "padil", "rafi", new DateTime(2022, 8, 29), 5_000_000, "utara", "QA");
            Programmer prog = new Programmer(1001, "iam", "rafi", new DateTime(2022, 8, 11), 6_000_000, " Jakarta ", 500_000);
            Sales sal = new Sales(1003, "Dios", "Syaban", new DateTime(2022, 9, 10), 3_000_000, "Bandung", 00_000, 100_000);
            QA qual = new QA(1004, "Burhan", "Sinyo", new DateTime(2022, 9, 11), 4_500_000, "Sumedang", 10_000);

            //List<Employee> ListEmployee = new List<Employee> { emp1, emp2, emp3, prog, sal, qual };
            //return ListEmployee;
            return new  List < Employee>  { emp1, emp2, emp3, prog, sal, qual };

            //throw new NotImplementedException();
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

        }

        public void showRole(Dictionary<string, int> list)
        {
        
          
                foreach (var item in list)
                {
                    Console.WriteLine($" Type = {item.Key} \n jumlah = {item.Value}");
                }
            
        }
    }
}
