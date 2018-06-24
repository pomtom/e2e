using e2edata.Models;
using System.Collections.Generic;

namespace e2ebusiness.Services
{
    public interface IEmployeeService
    {
        Employees GetEmployeeById(int id);
        IEnumerable<Employees> GetAllEmployee();
    }
}
