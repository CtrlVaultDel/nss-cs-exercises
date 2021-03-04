using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        // Read-only properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // List of Employees (Made of up Employee-type objects)
        public List<Employee> EmployeeList = new List<Employee>();

        // Constructor
        public Company(string name, DateTime date)
        {
            this.Name = name;
            this.CreatedOn = date;
        }

        // Used to write the list of employees, their titles, their company and when they started
        public void DisplayEmployees()
        {
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {this.Name} since {employee.StartDate.ToString("d")}");
            }
        }
    }
}