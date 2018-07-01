using e2edata.Models;
using System.Collections.Generic;
using System.Linq;

namespace e2edata.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly E2eDbContext context;

        public ProductRepository()
        {
            context = new E2eDbContext();
        }
        public IEnumerable<Products> GetAllProducts()
        {
            return this.context.Product.ToList();
        }
    }
}
