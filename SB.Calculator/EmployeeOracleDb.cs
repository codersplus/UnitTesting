using System.Collections.Generic;

namespace SB.Calculator
{
    public class EmployeeOracleDb : IEmployeeDb
    {
        public List<Employee> GetDatabaseEmployees()
        {
            var employees = new List<Employee>();

            employees.Add(new Employee("Mohsin", "Naveed"));

            return employees;
        }
    }
}