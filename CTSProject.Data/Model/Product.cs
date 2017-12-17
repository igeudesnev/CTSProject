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
        public int Count { get; set; }
        public string Name { get; set; }
        public MainPhoto MainPhoto { get; set; }
        public string Desctiption { get; set; }
        public double Rating { get; set; }
        public int ReviewsCount { get; set; }
        public List<Opinion> Opinions { get; set; }
    }
}
