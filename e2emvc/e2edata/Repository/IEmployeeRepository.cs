using e2edata.Models;
using e2eFramework;

namespace e2edata.Repository
{
    public interface IEmployeeRepository : IBaseRepository<Employees>
    {
        Employees GetSingle(int id);
    }
}
