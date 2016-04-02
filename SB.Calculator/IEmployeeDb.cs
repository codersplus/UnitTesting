using System.Collections.Generic;

namespace SB.Calculator
{
    public interface IEmployeeDb
    {
        List<Employee> GetDatabaseEmployees();
    }
}