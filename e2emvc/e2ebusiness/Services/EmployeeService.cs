using e2edata.Models;
using e2edata.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace e2ebusiness.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IProductRepository _productRepository;

        public EmployeeService(IEmployeeRepository employeeRepository,
            IProductRepository productRepository)
        {
            this._employeeRepository = employeeRepository;
            this._productRepository = productRepository;
        }

        public Employees GetEmployeeById(int id)
        {
            return _employeeRepository.GetSingle(id);
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return this._employeeRepository.GetAllEmployee();
        }

        public Tuple<int, int> GetEmployeeAndProductCount()
        {
            Tuple<int, int> tuple = new Tuple<int, int>(_employeeRepository.GetAllEmployee().ToList().Count, _productRepository.GetAllProducts().ToList().Count);
            return tuple;
        }
    }
}
