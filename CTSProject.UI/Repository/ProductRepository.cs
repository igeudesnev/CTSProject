using CTSProject.Data;
using CTSProject.Data.Model.ToDb;
using CTSProject.Data.Model.ToShop;
using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Repository
{
    class ProductRepository : Repository<Product>, IProductRepository<ProductToDb, ProductToShop>
    {
        public ProductRepository(OnlineShopContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductToShop> ReadAPI()
        {
            throw new NotImplementedException();
        }

        public List<Product> CategorySort(Category filter)
        {
            return _context.Products.Where(item => item.Category = filter);
        }
    }
}
