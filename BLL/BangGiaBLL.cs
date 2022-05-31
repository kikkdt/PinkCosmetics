using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class BangGiaBLL
    {
        /// <summary>
        /// Get all price types
        /// </summary>
        /// <returns>List of price types</returns>
        public static List<tb_BangGia> GetPriceTypes()
        {
            return new BangGiaDAL().GetPriceTypes();
        }
    }
}