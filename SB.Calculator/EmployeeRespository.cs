using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Calculator
{
    public class EmployeeRespository
    {

        private readonly IEmployeeDb _employeeDb;

        public EmployeeRespository(IEmployeeDb employeeDb)
        {
            _employeeDb = employeeDb;

        }
        public List<Employee> GetAllEmployees()
        {

            return _employeeDb.GetDatabaseEmployees();
        }

    }
}
