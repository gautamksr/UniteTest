using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class SqlEmployee : IsqlEmployee
    {
        public List<string> GetEmployee()
        {
            return new List<string> { "emp1", "emp2", "emp3" };
        }

        public async Task<List<string>> GetEmployeeAsync()
        {
            var empList = new List<string> { "emp1", "emp2", "emp3" };
            var empList1 = await Task.FromResult<List<string>>(empList);
            return empList1;
        }
    }

    public interface IsqlEmployee
    {
        List<string> GetEmployee();
        Task<List<string>> GetEmployeeAsync();
    }
}
