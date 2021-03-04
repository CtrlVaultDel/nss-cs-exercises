using System;

namespace classes
{
    public class Employee
    {
        // Read-only properties
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        // Constructor
        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
            this.StartDate = startDate;
        }
    }
}