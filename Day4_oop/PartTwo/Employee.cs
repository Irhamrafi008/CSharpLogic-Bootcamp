using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.PartTwo
{
    internal class Employee
    {

        //instant variable
        private int EmpId;
        private string FirstName;
        private string LastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string city;
        private string role;
        private decimal totalSalary;


        //static variable
        public static int totalEmployee = 0;
        public static decimal totalbasicSalary = 0M;


        //empty / default Constructor
        public Employee()
        {
            totalEmployee++;
            totalbasicSalary += this.basicSalary;
            this.totalSalary = this.basicSalary;
        }

        // Constructor Parameter
        public Employee(int empId, string firstName, 
            string lastName, DateTime joinDate, decimal basicSalary)
        {
            EmpId = empId; //new random(empID.Next(1000,1100));
            FirstName = firstName;
            LastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalbasicSalary += this.basicSalary;
            this.totalSalary = this.basicSalary;


        }

        //Overloading Construction

        public Employee(int empId, string firstName, 
            string lastName, DateTime joinDate, decimal basicSalary, string city) :
            this(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.city = city;
           
        }
        public Employee(int empId, string firstName, string lastName, 
            DateTime joinDate, decimal basicSalary, string city, string role) : 
            this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
           

        }

        public override string? ToString()
        {
            return $"Employee | {this.EmpId} | {this.FirstName1} | {this.LastName}| {this.role} | Basic Salary {this.basicSalary.ToString("C", new CultureInfo("id-ID"))}";
        }

    


        //get set

        public int EmpId1 { get => EmpId; set => EmpId = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary
        {
            get => basicSalary;
            set
            {
                basicSalary = value;
                totalSalary = basicSalary;

            }
        }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }
    }
}
