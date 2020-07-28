using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class Employee : IEmployee
    {
        private readonly IsqlEmployee isql;

        public Employee(IsqlEmployee isql)
        {
            this.isql = isql;
        }

        public List<string> GetEmployee()
        {
            return isql.GetEmployee();
        }

        public async Task<List<string>> GetEmployeeAscn()
        {
            return await isql.GetEmployeeAsync();
        }
    }

    public interface IEmployee
    {

        List<string> GetEmployee();

        Task<List<string>> GetEmployeeAscn();
    }
}
