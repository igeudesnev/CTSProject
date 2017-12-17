using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model
{
    public class Opinion
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public string Autor { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
