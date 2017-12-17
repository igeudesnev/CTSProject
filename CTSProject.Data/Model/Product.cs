using CTSProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model
{
    public class Product
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int ReviewsCount { get; set; }
    }
}
