// Create employees
using CSharp10FundamentalsExercises;

Employee employee1 = new Employee
{
    Name = "Jerry Lokoroi",
    JobTitle = "Developer",
    salary = 500000
};

Employee employee2 = new Employee
{
    Name = "Boniface Kabiru",
    JobTitle = "Designer",
    salary = 400000
};

// Create company
Company company = new Company
{
    Name = "StartUp Lions Company",
    Employees = new List<Employee> { employee1, employee2 }
};

// List employees
company.ListEmployees();
