using System.Collections.Generic;

namespace VogCodeChallenge.API.Core.Models
{
    public class Department : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
