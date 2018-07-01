using e2edata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2edata.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
    }
}
