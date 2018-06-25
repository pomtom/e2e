using e2edata.Models;
using System.Linq;
using System.Collections.Generic;

namespace e2edata.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository()
        {
            context = new E2eDbContext();
        }
        private readonly E2eDbContext context;

        public Employees GetSingle(int id)
        {
            return context.Employees.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return context.Employees.ToList();
        }
    }
}
