using System.Collections.Generic;
using VogCodeChallenge.API.Core.Models;

namespace VogCodeChallenge.API.Core.IRepositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
