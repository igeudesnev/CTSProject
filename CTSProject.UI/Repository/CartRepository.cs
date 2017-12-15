using CTSProject.Data;
using CTSProject.Data.Model.ToDb;
using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Repository
{
    class CartRepository: Repository<Cart>, ICartRepository<Cart, ProductToDb>
    {

        public CartRepository(OnlineShopContext context)
        {
            _context = context;
        }

        public void AddProduct(Cart cart, ProductToDb product)
        {
            cart.Products.Add(product);
        }

        public void RemoveProduct(Cart cart, ProductToDb product)
        {
            cart.Products.Remove(product);
        }

    }
}
