using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Interfaces
{
    public interface ICartRepository<T1, T2>: IRepository<T1>
    {
        //T1- cart
        //T2 - product in cart
        void AddProduct(T1 item1, T2 item2);
        void RemoveProduct(T1 item1, T2 item2);
    }
}
