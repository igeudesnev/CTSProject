﻿using CTSProject.Data;
using CTSProject.Data.Model;
using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Repository
{
    class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnlineShopContext context)
        {
            _context = context;
        }
    }
}
