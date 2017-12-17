using CTSProject.Data;
using CTSProject.Data.Model;
using CTSProject.UI.Interfaces;
using CTSProject.UI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI
{
    public class UnitOfWork:IDisposable
    {
        OnlineShopContext _context = new OnlineShopContext();

        public ICartRepository<Cart, Product> Carts { get; }
        public IProductRepository Products { get; }
        public IUserRepository Users { get; }
        public IOpinionRepository Opinions { get; }
        public IPhotoRepository MainPhotos { get; }
        public ICategoryRepository Categories { get; }

        public UnitOfWork()
        {
            Carts = new CartRepository(_context);
            Users = new UserRepository(_context);
            Products = new ProductRepository(_context);
            Opinions = new OpinionRepository(_context);
            MainPhotos = new PhotoRepository(_context);
            Categories = new CategoryRepository(_context);
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
