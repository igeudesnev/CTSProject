using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model.ToDb
{
    public class ProductToDb
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
