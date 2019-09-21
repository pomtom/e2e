using e2edata.Models;
using System.Collections.Generic;

namespace e2edata.Repository
{
    public interface IEmployeeRepository 
    {
        Employees GetSingle(int id);
        IEnumerable<Employees> GetAllEmployee();
        void CreateEmployee(Employees emp);
        void UpdateEmplouee(Employees emp);
    }
}
