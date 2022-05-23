using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class BangGiaDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all price types
        /// </summary>
        /// <returns>List of price types</returns>
        public List<tb_BangGia> GetPriceTypes()
        {
            return dataContext.tb_BangGias.Select(x => x).ToList();
        }
    }
}