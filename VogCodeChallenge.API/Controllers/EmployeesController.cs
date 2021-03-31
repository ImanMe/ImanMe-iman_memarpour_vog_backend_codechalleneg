using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Core.IRepositories;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Get()
        {
            var employees = _repository.ListAll();

            return Ok(employees);
        }

        [HttpGet("department/{departmentId}")]
        public IActionResult Get(int departmentId)
        {
            var employees = _repository.GetByDepartmentId(departmentId);

            return Ok(employees);
        }
    }
}
