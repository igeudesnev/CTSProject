using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Interfaces
{
     public interface IProductRepository<T1, T2> : IRepository<T1>
    {
        //T1 - product DB
        //T2 - product Shop
        IEnumerable<T2> ReadAPI();

        List<Product> CategorySort();
    }
}
