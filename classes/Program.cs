using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company
            Company wallyworld = new Company("Wallyworld", new DateTime(2021, 3, 4));

            // Create three employees
            Employee bob = new Employee("Bob", "Ross", "Staff Accountant", new DateTime(2021, 3, 4));
            Employee steve = new Employee("Steve", "Jobs", "Web Developer", new DateTime(2021, 3, 4));
            Employee morgan = new Employee("Morgan", "Freeman", "CEO", new DateTime(2021, 3, 4));

            // Assign the employees to the wallyworld
            wallyworld.EmployeeList.Add(bob);
            wallyworld.EmployeeList.Add(steve);
            wallyworld.EmployeeList.Add(morgan);

            // Display wallyworld's employees
            wallyworld.DisplayEmployees();
        }
    }
}
