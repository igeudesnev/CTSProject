using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model.ToShop
{
    public class MainPhoto
    {
        public int Id { get; set; }
        public ProductToShop Product { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string URL { get; set; }
    }
}
