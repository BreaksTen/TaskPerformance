namespace EmployeeManagementSystem;
public class Program
{
    public static void Main(string[] args)
    {
        IEmployee fullTime = new FullTimeEmployee("John", "Doe", "IT", "Software Engineer", 5000);
        fullTime.DisplaySalary();
        IEmployee partTime = new PartTimeEmployee("Jane", "Smith", "HR", "Recruiter", 20, 120);
        partTime.DisplaySalary();
        IEmployee intern = new Intern("Alice", "Johnson", "Marketing", "Intern", 1000);
        intern.DisplaySalary();
        IEmployee contractor = new ContractEmployee("Bob", "Brown", "Finance", "Consultant", 50, 100);
        contractor.DisplaySalary();

        Console.ReadLine();
    }
}