using CTSProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTSProject.UI.Interfaces;
using CTSProject.Data;

namespace CTSProject.UI.Repository
{
    class OpinionRepository: Repository<Opinion>, IOpinionRepository
    {
        public OpinionRepository(OnlineShopContext context)
        {
            _context = context;
        }
    }
}
