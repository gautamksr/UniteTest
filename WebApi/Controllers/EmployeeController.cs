using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee Employee;

        public EmployeeController(IEmployee employee)
        {
            Employee = employee;
        }
        [HttpGet]
        public ActionResult<List<string>> Get()
        {

            return Employee.GetEmployee();
        }
    }
}
