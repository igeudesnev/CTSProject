using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTSProject.Data.Model;

namespace CTSProject.UI.Interfaces
{
    public interface ICartRepository<T1, T2> : IRepository<Cart>
    {
        //T1- cart
        //T2 - product in cart
        void AddProduct(Cart item1, T2 item2);
        void RemoveProduct(Cart item1, T2 item2);
    }
}
