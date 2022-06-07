using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class BangGiaDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all price types
        /// </summary>
        /// <returns>List of price types</returns>
        public List<tb_BangGia> GetPriceTypes()
        {
            return _dataContext.tb_BangGia.Where(x => x.DaXoa == false).ToList();
        }
    }
}