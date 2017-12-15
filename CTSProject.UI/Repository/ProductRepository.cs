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
    class ProductRepository : Repository<ProductToDb>, IProductRepository<ProductToDb, ProductToShop>
    {
        public IEnumerable<ProductToShop> ReadAPI()
        {
            throw new NotImplementedException();
        }
    }
}
