using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model
{
    public class MainPhoto
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string URL { get; set; }
    }
}
