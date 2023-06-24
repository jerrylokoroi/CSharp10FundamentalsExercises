using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public void ListEmployees()
        {
            Console.WriteLine($"Employees of {Name}:");

            foreach (var employee in Employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Job Title: {employee.JobTitle}");
            }
        }
    }
}
