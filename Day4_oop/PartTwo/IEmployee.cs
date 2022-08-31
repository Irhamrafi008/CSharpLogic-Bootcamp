using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();

        public void ShowList<T>(ref List<T> list);

        public Employee findEmployeeById(List<Employee> list,int id);


        //method return with generic data type<T>
        public decimal GetTotalSalary<T>(ref List<T> list);

        public List<Employee> FindSalaryRange(List<Employee> list, decimal StartFrom, decimal EndTo);

        //aggregate summary total employee
        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list);

        public void showRole(Dictionary<string, int> list);
    }
}
