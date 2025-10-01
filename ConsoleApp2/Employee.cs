using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        public Employee(string FirstName, string LastName, string Department, string JobTitle)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Department = Department;
            this.JobTitle = JobTitle;
        }

        public abstract decimal CalculateSalary();


        public abstract void DisplaySalary();

         
     
        public class FullTimeEmployee : Employee
        {
            public decimal MonthlySalary { get; set; }

            public FullTimeEmployee(string FirstName, string LastName, string Department, string JobTitle, decimal MonthlySalary) : base(FirstName, LastName, Department, JobTitle)
            {
                this.MonthlySalary = MonthlySalary;
            }
            public override decimal CalculateSalary()
            {
                return MonthlySalary * 12;
            }
            public override void DisplaySalary()
            {
                Console.WriteLine("=== EMPLOYEE MANAGEMENT SYSTEM ===\n");
                Console.WriteLine("--- Employee Salary Information ---");
                Console.WriteLine("Name: " + FirstName + " " + LastName);
                Console.WriteLine("Department: " + Department);
                Console.WriteLine("Job Title: " + JobTitle);
                Console.WriteLine("Calculated Salary: " + CalculateSalary().ToString("C2"));
                Console.WriteLine("Salary Calculation: FullTimeEmployee = Monthly salary × 12");
                Console.WriteLine("--------------------------------------\n");
            }
        }

        public class PartTimeEmployee : Employee
        {
            public decimal RatePerHour { get; set; }
            public int TotalHoursWorked { get; set; }

            public PartTimeEmployee(string FirstName, string LastName, string Department, string JobTitle, decimal RatePerHour, int TotalHoursWorked) : base(FirstName, LastName, Department, JobTitle)
            {
                this.RatePerHour = RatePerHour;
                this.TotalHoursWorked = TotalHoursWorked;
            }
            public void AddHours(decimal hours)
            {

            }
            public override decimal CalculateSalary()
            {
                return TotalHoursWorked * RatePerHour;
            }

            public override void DisplaySalary()
            {

                Console.WriteLine("--- Employee Salary Information ---");
                Console.WriteLine("Name: " + FirstName + " " + LastName);
                Console.WriteLine("Department: " + Department);
                Console.WriteLine("Job Title: " + JobTitle);
                Console.WriteLine("Rate per Hour: " + RatePerHour);
                Console.WriteLine("Hours Worked: " + TotalHoursWorked);
                Console.WriteLine("Calculated Salary: " + CalculateSalary().ToString("C2"));
                Console.WriteLine("Salary Calculation: PartTimeEmployee = Hours worked × Hourly rate");
                Console.WriteLine("--------------------------------------\n");

            }

        }

        public class Intern : Employee
        {
            public decimal MonthlyStipend { get; set; }

            public Intern(string FirstName, string LastName, string Department, string JobTitle, decimal MonthlyStipend) : base(FirstName, LastName, Department, JobTitle)
            {
                this.MonthlyStipend = MonthlyStipend;
            }

            public void AddHours(decimal hours)
            {

            }
            public override decimal CalculateSalary()
            {
                return MonthlyStipend;
            }
            public override void DisplaySalary()
            {

                Console.WriteLine("--- Employee Salary Information ---");
                Console.WriteLine("Name: " + FirstName + " " + LastName);
                Console.WriteLine("Department: " + Department);
                Console.WriteLine("Job Title: " + JobTitle);
                Console.WriteLine("Calculated Salary: " + CalculateSalary().ToString("C2"));
                Console.WriteLine("Salary Calculation: Intern = Monthly Stipend");
                Console.WriteLine("--------------------------------------\n");
            }

        }

        public class ContractEmployee : Employee
        {
            public decimal RatePerHour { get; set; }
            public int TotalHoursWorked { get; set; }

            public ContractEmployee(string FirstName, string LastName, string Department, string JobTitle, decimal RatePerHour, int TotalHoursWorked) : base(FirstName, LastName, Department, JobTitle)
            {
                this.RatePerHour = RatePerHour;
                this.TotalHoursWorked = TotalHoursWorked;
            }
            public void AddHours(decimal hours)
            {

            }
            public override decimal CalculateSalary()
            {
                return TotalHoursWorked * RatePerHour;
            }
            public override void DisplaySalary()
            {

                Console.WriteLine("--- Employee Salary Information ---");
                Console.WriteLine("Name: " + FirstName + " " + LastName);
                Console.WriteLine("Department: " + Department);
                Console.WriteLine("Job Title: " + JobTitle);
                Console.WriteLine("Rate per Hour: " + RatePerHour);
                Console.WriteLine("Hours Worked: " + TotalHoursWorked);
                Console.WriteLine("Calculated Salary: " + CalculateSalary().ToString("C2"));
                Console.WriteLine("Salary Calculation: ContractEmployee = Hours worked × Hourly rate");
                Console.WriteLine("--------------------------------------");
            }

        }
    }
}
