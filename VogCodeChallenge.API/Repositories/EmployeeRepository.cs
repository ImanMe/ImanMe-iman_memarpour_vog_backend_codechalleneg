using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Core.IRepositories;
using VogCodeChallenge.API.Core.Models;
using VogCodeChallenge.API.MockData;

namespace VogCodeChallenge.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return EmployeeSeed.GetAll();
        }

        public IList<Employee> ListAll()
        {
            return EmployeeSeed.GetAll().ToList();
        }

        public IEnumerable<Employee> GetByDepartmentId(int departmentId)
        {
            return EmployeeSeed.GetAll().Where(e => e.DepartmentId == departmentId);
        }
    }
}
