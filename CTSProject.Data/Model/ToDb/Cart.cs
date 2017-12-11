using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model.ToDb
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<ProductToDb> Products { get; set; }
        public DateTime Date { get; set; }
    }
}
