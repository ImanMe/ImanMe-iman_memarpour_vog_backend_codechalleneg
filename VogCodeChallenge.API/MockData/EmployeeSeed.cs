using System.Collections.Generic;
using VogCodeChallenge.API.Core.Models;

namespace VogCodeChallenge.API.MockData
{
    public static class EmployeeSeed
    {
        public static IEnumerable<Employee> GetAll()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1, FirstName = "Sterling", LastName = "Archer", Address = "Somewhere in New York",
                    JobTitle = "World's Greatest Spy", DepartmentId = 1
                },
                new Employee
                {
                    Id = 2, FirstName = "Malory", LastName = "Archer", Address = "Somewhere in New York",
                    JobTitle = "Boss", DepartmentId = 1
                },
                new Employee
                {
                    Id = 3, FirstName = "Lana", LastName = "Kane", Address = "Somewhere in New York",
                    JobTitle = "Sidekick", DepartmentId = 1
                },
                new Employee
                {
                    Id = 4, FirstName = "Pam", LastName = "Poovey", Address = "Somewhere in New York",
                    JobTitle = "HR Manager", DepartmentId = 2
                }
            };

            return employees;
        }
    }
}
