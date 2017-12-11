using CTSProject.Data.Model.ToDb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data
{
    class Context: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductToDb> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public Context()
            : base("OnlineShopDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<Context>());
        }
    }
}
