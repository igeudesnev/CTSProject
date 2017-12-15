using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTSProject.Data;
using System.Linq.Expressions;

namespace CTSProject.UI.Repository
{
    class Repository<T>: IRepository<T> where T: class
    {
        protected OnlineShopContext _context;

        public void Add(T item)
        { _context.Set<T>().Add(item); }

        public void Remove(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public IEnumerable<T> Read()
        {
            return _context.Set<T>();
        }
    }
}
