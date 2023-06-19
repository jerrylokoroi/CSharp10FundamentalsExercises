using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    public class Employee
    {
        public string name;
        public int age;
        public double salary;

        Employee employee = new Employee("Jerry", 23, 40000);

        public Employee()
        {
        }

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void EmployeeSalaryRaise(double raiseAmount)
        {
            salary += raiseAmount;
        }

        
    }
}
