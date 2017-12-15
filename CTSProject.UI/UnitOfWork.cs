using CTSProject.Data;
using CTSProject.Data.Model.ToDb;
using CTSProject.Data.Model.ToShop;
using CTSProject.UI.Interfaces;
using CTSProject.UI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI
{
    class UnitOfWork:IDisposable
    {
        OnlineShopContext _context = new OnlineShopContext();

        public ICartRepository<Cart, ProductToDb> Carts { get; }
        public IProductRepository<ProductToDb, ProductToShop> Products { get; }
        public IUserRepository Users { get; }

        public UnitOfWork()
        {
            Carts = new CartRepository(_context);
            Users = new UserRepository(_context);
            Products = new ProductRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
