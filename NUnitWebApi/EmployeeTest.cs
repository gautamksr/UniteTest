using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using WebApi;

namespace NUnitWebApi
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
       

        [Test]
        public void GetEmployeeAsycnTest()
        {
            var var1 = new Mock<IsqlEmployee>();
            var1.Setup(x => x.GetEmployeeAsync()).ReturnsAsync(GetEmployeeResponse());

            IEmployee employee = new Employee(var1.Object);

            var result = employee.GetEmployeeAscn().Result;

            foreach (string item in result)
            {

                Assert.IsTrue(GetEmployeeResponse().Contains(item));
            }
            Assert.IsTrue(GetEmployeeResponse().Count == result.Count);
        }
        private List<string> GetEmployeeResponse()
        {
            return new List<string> { "emp1", "emp2" };
        }
    }
}