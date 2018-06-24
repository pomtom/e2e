using e2edata.Models;
using System.Linq;
using e2eFramework;

namespace e2edata.Repository
{
    public class EmployeeRepository : BaseRepository<E2eDbContext, Employees>, IEmployeeRepository
    {
        public Employees GetSingle(int id)
        {
            var employees = this.GetAll();
            return employees.FirstOrDefault(a => a.Id == id);
        }
    }
}
