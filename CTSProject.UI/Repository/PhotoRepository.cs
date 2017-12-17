using CTSProject.Data;
using CTSProject.Data.Model;
using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Repository
{
    class PhotoRepository: Repository<MainPhoto>, IPhotoRepository
    {
        public PhotoRepository(OnlineShopContext context)
        {
            _context = context;
        }
    }
}
