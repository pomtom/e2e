using System.Collections.Generic;
using System.Net.Http;
using e2edata.Models;
using e2edata.Repository;

namespace e2ebusiness.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public Employees GetEmployeeById(int id)
        {
            return _employeeRepository.GetSingle(id);
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return this._employeeRepository.GetAllEmployee();
        }
    }
}
