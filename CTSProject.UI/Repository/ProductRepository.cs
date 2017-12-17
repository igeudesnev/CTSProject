using CTSProject.Data;
using CTSProject.Data.Model;
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
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(OnlineShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> ReadAPI()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> CategorySort(Category filter, IEnumerable<Product> list)
        {
            return list.Where(item => item.Category == filter);
        }
    }
}
