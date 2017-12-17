﻿using CTSProject.Data.Model.ToDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.Data.Model.ToShop
{
    public class ProductToShop: ProductToDb
    {
        public string Name { get; set; }
        public MainPhoto MainPhoto { get; set; }
        public string Desctiption { get; set; }
        public int Rating { get; set; }
        public int ReviewsCount { get; set; }
        public List<Opinion> Opinions { get; set; }
    }
}