using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.PartTwo
{
    internal class QA : Employee
    {
        private decimal makan;

        public QA(int empId, string firstName, string lastName, 
            DateTime joinDate, decimal basicSalary, string city, decimal makan) :
            base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Makan = makan;
            Role = "QA";
            TotalSalary = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Uang Makan = {this.Makan.ToString("C", new CultureInfo("id-ID"))}" +
                $" | Total Salary = {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
