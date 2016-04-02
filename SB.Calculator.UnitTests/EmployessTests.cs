using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace SB.Calculator.UnitTests
{

    [TestFixture]
    public class EmployessTests
    {

        [Test]
        public void GetEmployees_WhenNoEmployeeExists_ShouldReturnZeroEmployees()
        {
            // Aarrange

            IEmployeeDb emp = new EmployeeOracleDb();

            var repo = new EmployeeRespository(emp);

            // Act
            List<Employee> employees = repo.GetAllEmployees();

            // Assert

            Assert.IsTrue(employees.Count == 1);

        }


        [Test]
        public void GetEmployees_WhenTwoEmployesExists_ShouldReturnTwoEmployess()
        {


           var employeeDb = new MockEmployeeSqlServerDb();

            var repo = new EmployeeRespository(employeeDb);

           Assert.AreEqual(2, repo.GetAllEmployees().Count());


        }


        public class MockEmployeeSqlServerDb : IEmployeeDb
        {
            public List<Employee> GetDatabaseEmployees()
            {
                var employees = new List<Employee>();

                employees.Add(new Employee("Mohsin", "Naveed"));
                employees.Add(new Employee("Siddique", "Bhatti"));

                return employees;
            }
        }

    }
}
