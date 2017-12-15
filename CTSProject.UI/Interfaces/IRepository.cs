using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);//Добавляет инфу в БД
        void Remove(T item);
        IEnumerable<T> Read();
    }
}
